using ComicManagerAPI.Models;
using ComicManagerAPI.Repositories.Interfaces;
using ComicManagerAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Services
{
    public class ComicCollectionManagerService : IComicCollectionManagerService
    {
        IComicCollectionManagerRepository _repo;

        public ComicCollectionManagerService(IComicCollectionManagerRepository repo)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public List<Comic> AddComicToCollection(Comic comicToAdd, string userName = "Default")
        {
            return _repo.AddComicToCollection(comicToAdd, userName);
        }

        public List<Comic> RemoveComicFromCollection(Comic comicToRemove, string userName = "Default")
        {
            return _repo.RemoveComicFromCollection(comicToRemove, userName);
        }

        public List<Comic> UpdateComicInCollection(Comic originalComic, Comic newComic, string userName = "Default")
        {
            return _repo.UpdateComicInCollection(originalComic, newComic, userName);
        }

        public List<Comic> SearchComicCollection(string name, int issue_number, string userName = "Default")
        {
            return _repo.SearchComicCollection(name, issue_number, userName);
        }

        public List<Comic> GetComicCollection(string username)
        {
            return _repo.GetComicCollection(username);
        }
    }
}
