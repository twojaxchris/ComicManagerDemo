using ComicManagerAPI.Models;
using ComicManagerAPI.Repositories.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Repositories
{
    public class ComicCollectionMongoDBRepository : IComicCollectionManagerRepository
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<UserComicCollection> collection;

        public ComicCollectionMongoDBRepository()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("ComicManagerDB");
            collection = _db.GetCollection<UserComicCollection>("ComicCollection");
        }

        public List<Comic> AddComicToCollection(Comic comicToAdd, string userName)
        {
            var userCollection = GetUserCollection(userName);
            userCollection.comicCollection.Add(comicToAdd);
            collection.ReplaceOneAsync(doc => doc.Id == userCollection.Id, userCollection);

            return userCollection.comicCollection;
        }

        public List<Comic> RemoveComicFromCollection(Comic comicToRemove, string userName)
        {
            var userCollection = GetUserCollection(userName);
            var existingComic = userCollection.comicCollection.Find(x => (x.issueNumber == comicToRemove.issueNumber)
                                                                          && (x.title == comicToRemove.title));
            if (existingComic != null)
                userCollection.comicCollection.Remove(existingComic);

            collection.ReplaceOneAsync(doc => doc.Id == userCollection.Id, userCollection);

            return userCollection.comicCollection;
        }

        public List<Comic> UpdateComicInCollection(Comic originalComic, Comic newComic, string userName)
        {
            var userCollection = GetUserCollection(userName);
            var existingComic = userCollection.comicCollection.Find(x => (x.issueNumber == originalComic.issueNumber)
                                                                          && (x.title == originalComic.title));

            if (existingComic != null)
            {
                var index = userCollection.comicCollection.IndexOf(existingComic);

                //This would be set my Mongo and not passed in via the API
                newComic.Id = existingComic.Id;
                if (index != -1)
                    userCollection.comicCollection[index] = newComic;
            }

            collection.ReplaceOneAsync(doc => doc.Id == userCollection.Id, userCollection);

            return userCollection.comicCollection;
        }
        public List<Comic> SearchComicCollection(string name, int issue_number, string userName)
        {
            var userCollection = GetUserCollection(userName);
            List<Comic> comicsFound = userCollection.comicCollection.FindAll(x => x.title == name 
                                                                    && x.issueNumber == issue_number.ToString());

            return comicsFound;
        }


        private UserComicCollection GetUserCollection(string userName)
        {
            var filter = Builders<UserComicCollection>.Filter.Eq("userName", userName);

            var document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                UserComicCollection userCollection = new UserComicCollection()
                {
                    userName = userName,
                    comicCollection = new List<Comic>()
                };
                
                collection.InsertOne(userCollection);
                document = userCollection;
            }

            return document;

        }
    }
}
