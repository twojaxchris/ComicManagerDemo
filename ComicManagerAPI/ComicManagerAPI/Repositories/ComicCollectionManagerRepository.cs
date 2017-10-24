using ComicManagerAPI.Models;
using ComicManagerAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Repositories
{
    public class ComicCollectionManagerRepository : IComicCollectionManagerRepository
    {
        public List<Comic> AddComicToCollection(Comic comicToAdd, string userName)
        {
            throw new NotImplementedException();
        }
        public List<Comic> RemoveComicFromCollection(Comic comicToRemove, string userName)
        {
            throw new NotImplementedException();
        }
        public List<Comic> UpdateComicInCollection(Comic comicToRemove, string userName)
        {
            throw new NotImplementedException();
        }
        public List<Comic> SearchComicCollection(string name, int issue_number, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
