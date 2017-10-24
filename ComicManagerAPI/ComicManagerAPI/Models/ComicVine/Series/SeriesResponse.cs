using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine.Series
{
    public class SeriesResponse
    {
        [JsonProperty("error")]
        public string error { get; set; }

        [JsonProperty("limit")]
        public int limit { get; set; }

        [JsonProperty("offset")]
        public int offset { get; set; }

        [JsonProperty("number_of_page_results")]
        public int number_of_page_results { get; set; }

        [JsonProperty("number_of_total_results")]
        public int number_of_total_results { get; set; }

        [JsonProperty("status_code")]
        public int status_code { get; set; }

        [JsonProperty("results")]
        public List<SeriesResult> results { get; set; }

        [JsonProperty("version")]
        public string version { get; set; }
    }
}
