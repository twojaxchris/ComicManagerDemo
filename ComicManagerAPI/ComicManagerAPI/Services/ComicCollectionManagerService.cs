using ComicManagerAPI.Models;
using ComicManagerAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Services
{
    public class ComicCollectionManagerService : IComicCollectionManagerService
    {
        public List<Comic> AddComicToCollection(Comic comicToAdd)
        {
            throw new NotImplementedException();
        }

        public List<Comic> RemoveComicFromCollection(Comic comicToRemove)
        {
            throw new NotImplementedException();
        }

        public List<Comic> UpdateComicInCollection(Comic comicToRemove)
        {
            throw new NotImplementedException();
        }

        public List<Comic> SearchComicCollection(string name, int issue_number)
        {
            throw new NotImplementedException();
        }
    }
}
