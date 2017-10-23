using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine.Series
{
    public class SeriesResult
    {
        [JsonProperty("aliases")]
        public string aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string api_detail_url { get; set; }

        [JsonProperty("count_of_issues")]
        public int count_of_issues { get; set; }

        [JsonProperty("date_added")]
        public string date_added { get; set; }

        [JsonProperty("date_last_updated")]
        public string date_last_updated { get; set; }

        [JsonProperty("deck")]
        public string deck { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("first_issue")]
        public SeriesIssue first_issue { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("image")]
        public Image image { get; set; }

        [JsonProperty("last_issue")]
        public SeriesIssue last_issue { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("publisher")]
        public SeriesPublisher publisher { get; set; }

        [JsonProperty("site_detail_url")]
        public string site_detail_url { get; set; }

        [JsonProperty("start_year")]
        public string start_year { get; set; }

        [JsonProperty("resource_type")]
        public string resource_type { get; set; }
    }
}
