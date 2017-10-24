using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class Comic
    {
        /// <summary>
        /// URL link to view comic details on an external website
        /// </summary>
        [JsonProperty("url")]
        public string url;

        /// <summary>
        /// Issue Title
        /// </summary>
        [JsonProperty("title")]
        public string title;

        /// <summary>
        /// Cover date of the comic
        /// </summary>
        [JsonProperty("coverDate")]
        public string coverDate;

        /// <summary>
        /// Issue number for the comic
        /// </summary>
        [JsonProperty("issueNumber")]
        public string issueNumber;

        /// <summary>
        /// URL for the image for the cover of the comic
        /// </summary>
        [JsonProperty("imageURL")]
        public string imageURL;
    }
}
