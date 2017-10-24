using ComicManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Services.Interfaces
{
    interface IComicCollectionManagerService
    {
        List<Comic> AddComicToCollection(Comic comicToAdd);
        List<Comic> RemoveComicFromCollection(Comic comicToRemove);
        List<Comic> UpdateComicInCollection(Comic comicToRemove);
        List<Comic> SearchComicCollection(string name, int issue_number);
    }
}
