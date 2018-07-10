using Microsoft.EntityFrameworkCore;
using blog.Data.Entitets;

namespace blog.Infrastructure
{
    public class TheBlogDb: DbContext
    {
        public TheBlogDb(DbContextOptions<TheBlogDb> options): 
            base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<TagList> TagList { get; set; }
        public DbSet<Comment> Comment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>();
            
            modelBuilder.Entity<Comment>()
                .HasOne(p => p.BlogPosts)
                .WithMany(b => b.Comments)
                .HasForeignKey(p => p.BlogPostId);
            
            modelBuilder.Entity<TagList>()
                .HasOne(p => p.BlogPost)
                .WithMany(b => b.TagLists)
                .HasForeignKey(p => p.BlogPostId);
        }
    }    
}