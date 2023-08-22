using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public long UserId { get; set; }
        public bool IsDeleted { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(2000);
            builder.HasOne(p => p.Category).WithMany(p=>p.Posts).HasForeignKey(p=>p.CategoryId);
            builder.HasOne(p=>p.User).WithMany(p=>p.Posts).HasForeignKey(p=>p.UserId);
        }
    }
}
