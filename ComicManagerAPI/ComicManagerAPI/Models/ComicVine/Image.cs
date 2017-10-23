using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models.ComicVine
{
    public class Image
    {
        [JsonProperty("icon_url")]
        public string icon_url { get; set; }

        [JsonProperty("medium_url")]
        public string medium_url { get; set; }

        [JsonProperty("screen_url")]
        public string screen_url { get; set; }

        [JsonProperty("screen_large_url")]
        public string screen_large_url { get; set; }

        [JsonProperty("small_url")]
        public string small_url { get; set; }

        [JsonProperty("super_url")]
        public string super_url { get; set; }

        [JsonProperty("thumb_url")]
        public string thumb_url { get; set; }

        [JsonProperty("tiny_url")]
        public string tiny_url { get; set; }
    }
}
