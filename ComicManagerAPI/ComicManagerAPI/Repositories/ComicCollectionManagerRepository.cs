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
        private List<Comic> blah;

        public ComicCollectionManagerRepository()
        {
            blah = new List<Comic>();

            blah.Add(new Comic
            {
                title = "Test Comic 1",
                url = "www.google.com",
                coverDate = "10/23/2017",
                imageURL = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                issueNumber = "1"
            });
            blah.Add(new Comic
            {
                title = "Test Comic 2",
                url = "www.google.com",
                coverDate = "10/23/2017",
                imageURL = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                issueNumber = "2"
            });
            blah.Add(new Comic
            {
                title = "Test Comic 3",
                url = "www.google.com",
                coverDate = "10/23/2017",
                imageURL = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                issueNumber = "3"
            });

        }

        public List<Comic> AddComicToCollection(Comic comicToAdd, string userName)
        {
            blah.Add(comicToAdd);
            return blah;
        }
        public List<Comic> RemoveComicFromCollection(Comic comicToRemove, string userName)
        {
            blah.Remove(comicToRemove);
            return blah;
        }
        public List<Comic> UpdateComicInCollection(Comic originalComic, Comic newComic, string userName)
        {
            Comic resultComic = blah.Find(x => x == originalComic);
            resultComic.title = newComic.title;
            resultComic.issueNumber = newComic.issueNumber;
            resultComic.imageURL = newComic.imageURL;
            resultComic.url = newComic.url;
            resultComic.coverDate = newComic.coverDate;
            return blah;
        }
        public List<Comic> SearchComicCollection(string name, int issue_number, string userName)
        {
            List<Comic> blahFound = blah.Where(x => x.title == name && x.issueNumber == issue_number.ToString()).ToList();
            return blahFound;
        }
    }
}
