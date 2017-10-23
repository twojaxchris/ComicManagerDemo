using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class Series
    {
        /// <summary>
        /// The name of the series
        /// </summary>
        string name;

        /// <summary>
        /// The year the series began
        /// </summary>
        string startYear;

        /// <summary>
        /// URL for the image for the series; often the first comic
        /// </summary>
        string imageUrl;

        /// <summary>
        /// External site for more information about the series
        /// </summary>
        string url;

        /// <summary>
        /// The name of the publisher
        /// </summary>
        string publisherName;
    }
}
