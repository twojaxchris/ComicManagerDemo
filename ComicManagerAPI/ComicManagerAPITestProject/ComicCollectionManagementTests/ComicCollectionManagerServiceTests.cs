using ComicManagerAPI.Models;
using ComicManagerAPI.Repositories;
using ComicManagerAPI.Repositories.Interfaces;
using ComicManagerAPI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComicManagerAPITestProject.ComicCollectionManagementTests
{
    [TestClass]
    public class ComicCollectionManagerServiceTests
    {
        protected readonly ComicCollectionManagerService ServiceToTest;
        protected ComicCollectionMongoDBRepository Repo;
        protected Comic NewComic;
        protected Comic UpdateComic;
        protected Comic SearchComic;

        public ComicCollectionManagerServiceTests()
        {
            Repo = new ComicCollectionMongoDBRepository();
            ServiceToTest = new ComicCollectionManagerService(Repo);
            NewComic = new Comic()
            {
                title = "ComicAdded",
                url = String.Empty,
                coverDate = String.Empty,
                imageURL = String.Empty,
                issueNumber = "12"
            };
            UpdateComic = new Comic()
            {
                title = "ComicUpdated",
                url = String.Empty,
                coverDate = String.Empty,
                imageURL = String.Empty,
                issueNumber = "13"
            };
            SearchComic = new Comic()
            {
                title = "ComicSearched",
                url = String.Empty,
                coverDate = String.Empty,
                imageURL = String.Empty,
                issueNumber = "15"
            };

        }

        [TestMethod]
        public void TestCollectionAdding()
        {
            List<Comic> revisedCollection = ServiceToTest.AddComicToCollection(NewComic);
            Assert.IsNotNull(revisedCollection);
            Assert.IsTrue(revisedCollection.Contains(NewComic));

        }

        [TestMethod]
        public void TestCollectionSearching()
        {
            List<Comic> revisedCollection = ServiceToTest.AddComicToCollection(SearchComic);
            Assert.IsNotNull(revisedCollection);
            Assert.IsTrue(revisedCollection.Contains(SearchComic));

            List<Comic> searchResults = ServiceToTest.SearchComicCollection(SearchComic.title, Int32.Parse(SearchComic.issueNumber));
            Assert.IsNotNull(searchResults);
            Assert.IsTrue(searchResults.Find(x => x.title == SearchComic.title && x.issueNumber == SearchComic.issueNumber) != null);
        }

        [TestMethod]
        public void TestCollectionUpdating()
        {

            List<Comic> revisedCollection = ServiceToTest.AddComicToCollection(UpdateComic);
            Assert.IsNotNull(revisedCollection);
            Assert.IsTrue(revisedCollection.Contains(UpdateComic));

            Comic comicAfterUpdate = new Comic()
            {
                title = UpdateComic.title,
                issueNumber = UpdateComic.issueNumber,
                url = UpdateComic.url,
                imageURL = UpdateComic.imageURL,
                coverDate = UpdateComic.coverDate
            };

            comicAfterUpdate.issueNumber = "14";
            comicAfterUpdate.title = "Comic as been updated";

            revisedCollection = ServiceToTest.UpdateComicInCollection(UpdateComic, comicAfterUpdate);

            Assert.IsTrue(revisedCollection.Find(x => x.title == comicAfterUpdate.title
                                                && x.issueNumber == comicAfterUpdate.issueNumber) != null);
        }

        [TestMethod]
        public void TestCollectionDeleting()
        {
            List<Comic> revisedCollection = ServiceToTest.RemoveComicFromCollection(NewComic);
            Assert.IsNotNull(revisedCollection);
            Assert.IsTrue(!revisedCollection.Contains(NewComic));
        }

    }
}
