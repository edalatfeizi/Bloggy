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
          
    public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property<string>("_about")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("About")
               .HasMaxLength(500)
               .IsRequired();

            builder.Property<string>("_image")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Image");

            builder.Property<string>("_email")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Email")
            .IsRequired();

            builder.Property<string>("_password")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Password")
            .IsRequired();

            builder.Property<bool>("_status")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Status")
            .IsRequired();
        }
    }
}
