using ComicManagerAPI.Models;
using ComicManagerAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComicManagerAPITestProject.ComicVineIntegrationTests
{
    [TestClass]
    public class ComicVineIntegrationServiceTests
    {
        protected readonly ComicVineIntegrationService ServiceToTest;
        protected Mock<ILogger<ComicVineIntegrationService>> LoggerMock;

        public ComicVineIntegrationServiceTests()
        {
            LoggerMock = new Mock<ILogger<ComicVineIntegrationService>>();
            ServiceToTest = new ComicVineIntegrationService(LoggerMock.Object);
        }

        [TestMethod]
        public async Task SearchIssuesTest()
        {
            List<Comic> comics = await ServiceToTest.SearchIssues("Batman", 4);

            Assert.IsNotNull(comics);
            Assert.IsTrue(comics.Count >= 19);
            Assert.IsTrue(comics[0].title.Contains("Batman"));
        }

        [TestMethod]
        public async Task SearchSeriesTest()
        {
            List<Series> series = await ServiceToTest.SearchSeries("Batman");

            Assert.IsNotNull(series);
            Assert.IsTrue(series.Count >= 9);
            Assert.IsTrue(series[0].name.Contains("Batman"));
        }

        [TestMethod]
        public async Task SearchPublisherTest()
        {
            List<Publisher> publishers = await ServiceToTest.SearchPublishers("Marvel");

            Assert.IsNotNull(publishers);
            Assert.IsTrue(publishers.Count >= 8);
            Assert.IsTrue(publishers[0].name.Contains("Marvel"));
        }
    }
}
