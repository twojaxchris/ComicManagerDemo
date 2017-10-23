using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine.Series
{
    public class SeriesIssue
    {
        [JsonProperty("api_detail_url")]
        public string api_detail_url { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("issue_number")]
        public string issue_number { get; set; }
    }
}
