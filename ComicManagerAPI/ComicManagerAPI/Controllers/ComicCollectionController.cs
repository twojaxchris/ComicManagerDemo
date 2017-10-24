using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicManagerAPI.Models;
using Microsoft.AspNetCore.Http;
using ComicManagerAPI.Services.Interfaces;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicManagerAPI.Controllers
{
    [Route("api/[controller]")]
    public class ComicCollectionController : Controller
    {
        IComicCollectionManagerService _collectionManagerService;

        public ComicCollectionController(IComicCollectionManagerService collectionManagerService)
        {
            _collectionManagerService = collectionManagerService ?? throw new ArgumentNullException(nameof(collectionManagerService));
        }

        [Route("addcomic")]
        [HttpPost]
        [ProducesResponseType(typeof(List<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddComic([FromBody]PostBody post)
        {
            if (post != null)
            {
                var revisedCollection = _collectionManagerService.AddComicToCollection(post.comic, post.userName);
                return CreatedAtAction
                    (
                        nameof(AddComic),
                        revisedCollection
                    );
            }
            else
                return BadRequest();
        }

        [Route("updatecomic")]
        [HttpPut]
        [ProducesResponseType(typeof(List<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateComic([FromBody]PostBody post)
        {
            if (post != null)
            {
                var revisedCollection = _collectionManagerService.UpdateComicInCollection(post.comic, post.updatedComic, post.userName);
                return Ok(revisedCollection);
            }
            else
                return BadRequest();
        }

        [Route("deletecomic")]
        [HttpDelete]
        [ProducesResponseType(typeof(List<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteComic([FromBody]PostBody post)
        {
            if (post != null)
            {
                var revisedCollection = _collectionManagerService.RemoveComicFromCollection(post.comic, post.userName);
                return Ok(revisedCollection);
            }
            else
                return BadRequest();
        }

        [Route("searchcomics")]
        [HttpGet("{name}/{issue_number}/{username}")]
        [ProducesResponseType(typeof(IEnumerable<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SearchComic(string name, int issue_number, string username)
        {
            var comics = _collectionManagerService.SearchComicCollection(name, issue_number, username);
            return Ok(comics);
        }

        [Route("getcomiccollection")]
        [HttpGet("{username}")]
        [ProducesResponseType(typeof(IEnumerable<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetComicCollection(string username)
        {
            var comics = _collectionManagerService.GetComicCollection(username);
            return Ok(comics);
        }
    }
}
