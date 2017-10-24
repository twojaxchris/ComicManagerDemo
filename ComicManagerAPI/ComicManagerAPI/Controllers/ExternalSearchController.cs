using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicManagerAPI.Services.Interfaces;
using ComicManagerAPI.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicManagerAPI.Controllers
{
    [Route("api/[controller]")]
    public class ExternalSearchController : Controller
    {
        private readonly IComicIntegrationService _comicService;

        public ExternalSearchController(IComicIntegrationService comicService)
        {
            _comicService = comicService ?? throw new ArgumentNullException(nameof(comicService));
        }

        
        [Route("searchissues")]
        [HttpGet("{name}/{issue_number}")]
        [ProducesResponseType(typeof(IEnumerable<Comic>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SearchIssues(string name, int issue_number) 
        {
            var comics = await _comicService.SearchIssues(name, issue_number);
            return Ok(comics);
        }

        [Route("searchseries")]
        [HttpGet("{name}")]
        [ProducesResponseType(typeof(IEnumerable<Series>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SearchSeries(string name)
        {
            var series = await _comicService.SearchSeries(name);
            return Ok(series);
        }

        [Route("searchpublishers")]
        [HttpGet("{name}")]
        [ProducesResponseType(typeof(IEnumerable<Publisher>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SearchPublishers(string name)
        {
            var publishers = await _comicService.SearchSeries(name);
            return Ok(publishers);
        }
    }
}
