using MicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroService.DAL
{
    public class MicroServiceDbContext :DbContext
    {

        public MicroServiceDbContext(DbContextOptions<MicroServiceDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<BlogPost> Posts { get; set; }


    }
}
