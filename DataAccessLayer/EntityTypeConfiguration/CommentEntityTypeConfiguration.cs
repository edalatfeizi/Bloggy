using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityTypeConfiguration
{
          
    public class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_user_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserName");

            builder.Property<string>("_title")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Title");

            builder.Property<string>("_content")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Content");

            builder.Property<DateTime>("_date")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Date");


            builder.Property<bool>("_status")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Status")
            .IsRequired();

            builder.HasOne(c => c.Post)
              .WithMany()
              .HasForeignKey("_post_id");
        }
    }
}
