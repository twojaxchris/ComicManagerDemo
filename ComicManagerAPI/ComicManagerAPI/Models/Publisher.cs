using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class Publisher
    {
        /// <summary>
        /// The name of the company
        /// </summary>
        [BsonElement("name")]
        [JsonProperty("name")]
        public string name { get; set; }

        /// <summary>
        /// A link to an external site with more details about the publisher
        /// </summary>
        [BsonElement("url")]
        [JsonProperty("url")]
        public string url { get; set; }

        /// <summary>
        /// A link to an external site image for the publisher
        /// </summary>
        [BsonElement("imageUrl")]
        [JsonProperty("imageUrl")]
        public string imageUrl { get; set; }
    }
}
