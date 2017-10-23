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
            Assert.AreEqual(19, comics.Count);
        }

        private ILogger CreateLogger()
        {
            var serviceProvider = new ServiceCollection()
                                        .AddLogging()
                                        .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<ComicVineIntegrationService>();

            return logger;
        }
    }
}
