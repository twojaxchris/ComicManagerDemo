using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class PostBody
    {
        [JsonProperty("comic")]
        public Comic comic { get; set; }

        [JsonProperty("updatedComic")]
        public Comic updatedComic { get; set; }

        [JsonProperty("userName")]
        public string userName { get; set; }
    }
}

