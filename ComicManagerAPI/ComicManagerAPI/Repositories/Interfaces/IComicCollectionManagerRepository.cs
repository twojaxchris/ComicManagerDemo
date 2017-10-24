using ComicManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Repositories.Interfaces
{
    public interface IComicCollectionManagerRepository
    {
        List<Comic> AddComicToCollection(Comic comicToAdd, string userName);
        List<Comic> RemoveComicFromCollection(Comic comicToRemove, string userName);
        List<Comic> UpdateComicInCollection(Comic originalComic, Comic newComic, string userName);
        List<Comic> SearchComicCollection(string name, int issue_number, string userName);
        List<Comic> GetComicCollection(string userName);
    }
}
