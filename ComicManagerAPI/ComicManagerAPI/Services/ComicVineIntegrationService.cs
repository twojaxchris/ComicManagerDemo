using ComicManagerAPI.Models;
using ComicManagerAPI.Models.ComicVine;
using ComicManagerAPI.Models.ComicVine.Issue;
using ComicManagerAPI.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ComicManagerAPI.Services
{
    public class ComicVineIntegrationService : IComicIntegrationService
    {

        private readonly string apiURL = $"https://comicvine.gamespot.com/api/";

        //Location on the drive for the personal API Key
        string _apiKeyLocation = "APIKey.txt";
        string _key;
        ILogger _logger;

        public ComicVineIntegrationService(ILogger<ComicVineIntegrationService> logger)
        {
            _logger = logger;
            GetAPIKey();
        }
        
        public async Task<List<Comic>> SearchIssues(string name, int issue_number)
        {
            string issueURL = $"issues/?api_key={ _key}&format=json";
            string filterUrl = CreateIssueFilterUrl(name, issue_number);
            string finalUrl = apiURL + issueURL + filterUrl;

            string response = await CallComicVineAPI(finalUrl);
            var rootResult = JsonConvert.DeserializeObject<IssueResponse>(response);

            return CreateComicObjectsFromIssueResults(rootResult.results);
        }


        #region Private
        
        //Refactor this later. This is just a quick and dirty way to keep the key off git
        private void GetAPIKey()
        {
            string savedKey = null;

            try
            {
                savedKey = System.IO.File.ReadAllText(_apiKeyLocation);
            }
            catch (Exception e)
            {
                _logger.LogError("ComicVineIntegrationService.GetAPIKey: Error opening file to read API Key. Exception: " + e.ToString());
            }
            
            var match = Regex.Match(savedKey, @"[^a-zA-Z\d\s:]");
            if (!match.Success)
                _key = savedKey;
            else
                throw new Exception("The API Key you are trying to use it malformed and contained unsupported characters. Please check it and try again");
        }

        private string CreateIssueFilterUrl(string name, int issue_number)
        {
            string filterString = "&filter=";
            string nameFilter = !String.IsNullOrEmpty(name) 
                                        ? $"name:{name}" 
                                        : String.Empty;
            string issueNumString = (issue_number > 0) 
                                        ? $"issue_number:{issue_number.ToString()}" 
                                        : String.Empty;

            string filterUrl = !String.IsNullOrEmpty(nameFilter)
                                ? filterString + nameFilter + "," 
                                : filterString;
            filterUrl = !String.IsNullOrEmpty(issueNumString)
                                ? filterUrl + issueNumString
                                : filterUrl.Remove(filterUrl.Length -1); //remove the comma if no issue number

            return filterUrl;
        }

        private async Task<string> CallComicVineAPI(string vineUrl)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");
                HttpResponseMessage response = await client.GetAsync(vineUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                    return null;
            }
        }

        private List<Comic> CreateComicObjectsFromIssueResults(List<IssueResult> results)
        {
            List<Comic> comics = new List<Comic>();

            foreach (IssueResult result in results)
            {
                comics.Add(new Comic
                {
                    issueNumber = result.issue_number,
                    coverDate = result.cover_date,
                    imageURL = result.image.medium_url,
                    title = result.volume.name,
                    url = result.volume.site_detail_url
                });
            }

            return comics;
        }

        #endregion
    }
}
