using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityTypeConfiguration
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property<string>("_description")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Description");


            builder.Property<bool>("_status")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Status");

            builder.HasMany(p => p.Posts)
                    .WithMany(c => c.Categories)
                    .UsingEntity(j => j.ToTable("PostCategory"));


        }
    }
}
