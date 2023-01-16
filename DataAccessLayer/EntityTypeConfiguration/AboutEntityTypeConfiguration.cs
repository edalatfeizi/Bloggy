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
          
    public class AboutEntityTypeConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable("Abouts", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_details1")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Details1");

            builder.Property<string>("_details2")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Details2");

            builder.Property<string>("_image1")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Image1");

            builder.Property<string>("_image2")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Image2");

            builder.Property<string>("_map_location")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("MapLocation");

            builder.Property<bool>("_status")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Status")
            .IsRequired();
        }
    }
}
