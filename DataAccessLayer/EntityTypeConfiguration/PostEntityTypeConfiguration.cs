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
    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
         
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_title")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Title")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property<string>("_content")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Content")
                .IsRequired();

            builder.Property<string>("_thumbnailImage")
              .UsePropertyAccessMode(PropertyAccessMode.Field)
              .HasColumnName("ThumbnailImage")
              .IsRequired();

            builder.Property<string>("_image")
              .UsePropertyAccessMode(PropertyAccessMode.Field)
              .HasColumnName("Image")
              .IsRequired();

            builder.Property<DateTime>("_createDate")
             .UsePropertyAccessMode(PropertyAccessMode.Field)
             .HasColumnName("CreateDate")
             .IsRequired();

            builder.Property<DateTime>("_updateDate")
             .UsePropertyAccessMode(PropertyAccessMode.Field)
             .HasColumnName("UpdateDate")
             .IsRequired();



            builder.Property<bool>("_status")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Status");

            builder.HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey("_author_id");

            
                
        }
    }
}
