using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine.Publisher
{
    public class PublisherResult
    {
        [JsonProperty("aliases")]
        public string aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string api_detail_url { get; set; }

        [JsonProperty("date_added")]
        public string date_added { get; set; }

        [JsonProperty("date_last_updated")]
        public string date_last_updated { get; set; }

        [JsonProperty("deck")]
        public string deck { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("image")]
        public Image image { get; set; }

        [JsonProperty("location_address")]
        public string location_address { get; set; }

        [JsonProperty("location_city")]
        public string location_city { get; set; }

        [JsonProperty("location_state")]
        public string location_state { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("site_detail_url")]
        public string site_detail_url { get; set; }
    }
}
