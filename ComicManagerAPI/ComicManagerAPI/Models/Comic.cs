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
        public string url;

        /// <summary>
        /// Issue Title
        /// </summary>
        public string title;

        /// <summary>
        /// Cover date of the comic
        /// </summary>
        public string coverDate;

        /// <summary>
        /// Issue number for the comic
        /// </summary>
        public string issueNumber;

        /// <summary>
        /// URL for the image for the cover of the comic
        /// </summary>
        public string imageURL;
    }
}
