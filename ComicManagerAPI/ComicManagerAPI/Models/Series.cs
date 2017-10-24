using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class Series
    {
        [JsonProperty("seriesID")]
        public int seriesID { get; set; }

        /// <summary>
        /// The name of the series
        /// </summary>
        [JsonProperty("name")]
        public string name { get; set; }

        /// <summary>
        /// The year the series began
        /// </summary>
        [JsonProperty("startYear")]
        public string startYear { get; set; }

        /// <summary>
        /// URL for the image for the series; often the first comic
        /// </summary>
        [JsonProperty("imageUrl")]
        public string imageUrl { get; set; }

        /// <summary>
        /// External site for more information about the series
        /// </summary>
        [JsonProperty("url")]
        public string url { get; set; }

        /// <summary>
        /// The name of the publisher
        /// </summary>
        [JsonProperty("publisherName")]
        public string publisherName { get; set; }
    }
}
