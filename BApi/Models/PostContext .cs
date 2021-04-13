using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BApi.Models
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {
            //this.Posts.RemoveRange(this.Posts);
            //seed();
        }
        protected async  void seed()
        {
            this.Posts.RemoveRange(this.Posts);
            await this.Posts.AddAsync(new Post { id=1,  author = "maryam", content = "post 1" });
            await this.Posts.AddAsync(new Post { id=2, author = "salma", content = "post 2" });
            await this.Posts.AddAsync(new Post { id=3, author = "hazem", content = "post 3" });
            await this.Posts.AddAsync(new Post { id=4, author = "mohsen", content = "post 4" });
            await SaveChangesAsync();

        }
        public DbSet<Post> Posts { get; set; }
    }
}
