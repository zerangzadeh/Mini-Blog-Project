using Microsoft.EntityFrameworkCore;
using MiniBlog.Mapping;
using MiniBlog.Models;

namespace MiniBlog
{
    public class ArticleContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);


        }

    }

}



