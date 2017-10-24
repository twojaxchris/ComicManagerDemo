using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicManagerAPI.Models;
using Microsoft.AspNetCore.Http;
using ComicManagerAPI.Services.Interfaces;

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

        [HttpPost]
        [ProducesResponseType(typeof(List<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddComic([FromBody]Comic comic, [FromBody]string username)
        {
            var revisedCollection = _collectionManagerService.AddComicToCollection(comic, username);
            return CreatedAtAction
                (
                    nameof(AddComic),
                    revisedCollection
                );
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateComic([FromBody]Comic originalcomic, [FromBody]Comic revisedComic, [FromBody]string username)
        {
            var revisedCollection = _collectionManagerService.UpdateComicInCollection(originalcomic, revisedComic, username);
            return Ok(revisedCollection);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(List<Comic>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteComic([FromBody]Comic comic, [FromBody]string username)
        {
            var revisedCollection = _collectionManagerService.RemoveComicFromCollection(comic, username);
            return Ok(revisedCollection);
        }
    }
}
