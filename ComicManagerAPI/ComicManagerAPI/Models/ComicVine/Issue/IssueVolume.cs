using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine.Issue
{
    public class IssueVolume
    {
        [JsonProperty("api_detail_url")]
        public string api_detail_url { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("site_detail_url")]
        public string site_detail_url { get; set; }
    }
}
