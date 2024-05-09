using MicroService.DAL;
using MicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroService
{
    public class CRUDService :ICRUDService
    {
        private readonly MicroServiceDbContext _context;

        public CRUDService(MicroServiceDbContext context)
        {
            _context = context;
        }

        public async Task<BlogPost> CreatePost(BlogPost post)
        {
            var result = await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<BlogPost>> GetAllPosts()
        {
            var result = await _context.Posts.ToListAsync();

            return result;
        }





    }
}
