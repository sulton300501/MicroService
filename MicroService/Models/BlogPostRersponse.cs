namespace MicroService.Models
{
    public class BlogPostRersponse
    {
        public BlogPost RedisBlogPost { get; set; }

        public List<BlogPost> PostgressBlogPost { get; set; }
    }
}
