using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBlog.Models;

namespace MiniBlog.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x=>x.ArticleID);
            builder.Property(x=>x.Title).IsRequired();  
            builder.Property(x=>x.Body).IsRequired();

        }
    }
}
