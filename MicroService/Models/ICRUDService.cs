namespace MicroService.Models
{
    public interface ICRUDService
    {
        public Task<BlogPost> CreatePost(BlogPost post);
        public Task<List<BlogPost>> GetAllPosts();
    }
}
