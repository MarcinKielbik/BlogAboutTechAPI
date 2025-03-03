using BlogAboutTechAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogAboutTechAPI.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }



    }
}
