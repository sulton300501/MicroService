using MicroService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {

        private readonly ICRUDService _crudService;

        public BlogPostsController(ICRUDService crudService)
        {
            _crudService = crudService;
        }



        [HttpPost]
        public async Task<IActionResult> CreatePost(BlogPost post)
        {
            var result = await _crudService.CreatePost(post);

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var result = await _crudService.GetAllPosts();

            return Ok(result);
        }




    }
}
