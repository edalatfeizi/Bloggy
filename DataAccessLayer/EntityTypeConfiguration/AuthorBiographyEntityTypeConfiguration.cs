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
          
    public class AuthorBiographyEntityTypeConfiguration : IEntityTypeConfiguration<AuthorBiography>
    {
        public void Configure(EntityTypeBuilder<AuthorBiography> builder)
        {
            builder.ToTable("AuthorBiographies", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_biography")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Biography")
            .IsRequired();

            //builder.HasOne(a => a.Biography)
            //.WithOne(b => b.Author)
            //.HasForeignKey<AuthorBiography>(b => b.AuthorId);
        }
    }
}
