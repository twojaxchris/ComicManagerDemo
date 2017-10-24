using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Models
{
    public class UserComicCollection
    {
        public ObjectId Id { get; set; }

        //TODO: set auto-incrementing primary key for collections
        //For now, just the username will work as proof of concept
        
        //[BsonElement("comicCollectionID")]
        //public int comicCollectionID { get; set; }

        [BsonElement("userName")]
        public string userName { get; set; }

        [BsonElement("comicCollection")]
        public List<Comic> comicCollection { get; set; }
    }
}
