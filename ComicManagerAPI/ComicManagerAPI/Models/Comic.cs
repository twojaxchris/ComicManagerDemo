using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class Comic
    {
        public ObjectId Id { get; set; }

        [BsonElement("comicID")]
        [JsonProperty("comicID")]
        public int comicID { get; set; }

        /// <summary>
        /// URL link to view comic details on an external website
        /// </summary>
        [BsonElement("url")]
        [JsonProperty("url")]
        public string url { get; set; }

        /// <summary>
        /// Issue Title
        /// </summary>
        [BsonElement("title")]
        [JsonProperty("title")]
        public string title { get; set; }

        /// <summary>
        /// Cover date of the comic
        /// </summary>
        [BsonElement("coverDate")]
        [JsonProperty("coverDate")]
        public string coverDate { get; set; }

        /// <summary>
        /// Issue number for the comic
        /// </summary>
        [BsonElement("issueNumber")]
        [JsonProperty("issueNumber")]
        public string issueNumber { get; set; }

        /// <summary>
        /// URL for the image for the cover of the comic
        /// </summary>
        [BsonElement("imageURL")]
        [JsonProperty("imageURL")]
        public string imageURL { get; set; }
    }
}
