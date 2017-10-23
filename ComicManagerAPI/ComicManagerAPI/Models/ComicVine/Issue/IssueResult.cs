using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine.Issue
{
    public class IssueResult
    {
        [JsonProperty("aliases")]
        public object aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string api_detail_url { get; set; }

        [JsonProperty("cover_date")]
        public string cover_date { get; set; }

        [JsonProperty("date_added")]
        public string date_added { get; set; }

        [JsonProperty("date_last_updated")]
        public string date_last_updated { get; set; }

        [JsonProperty("deck")]
        public object deck { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("has_staff_review")]
        public bool has_staff_review { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("image")]
        public Image image { get; set; }

        [JsonProperty("issue_number")]
        public string issue_number { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("site_detail_url")]
        public string site_detail_url { get; set; }

        [JsonProperty("store_date")]
        public string store_date { get; set; }

        [JsonProperty("volume")]
        public IssueVolume volume { get; set; }

        [JsonProperty("resource_type")]
        public string resource_type { get; set; }
    }
}
