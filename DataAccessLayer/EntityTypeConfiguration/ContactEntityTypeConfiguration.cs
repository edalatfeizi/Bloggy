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
          
    public class ContactEntityTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts", BlogDbContext.DB_SCHEMA);
            builder.HasKey(a => a.Id);

            builder.Property<string>("_user_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserName");

            builder.Property<string>("_email")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Email");

            builder.Property<string>("_subject")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Subject");

            builder.Property<string>("_message")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Message");

            builder.Property<DateTime>("_date")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Date");

            builder.Property<bool>("_status")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Status")
            .IsRequired();
        }
    }
}
