using DataAccessLayer.EntityTypeConfiguration;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class BlogDbContext : DbContext
    {

        public const string DB_SCHEMA = "blog";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MN1U1M6;database=BlogDb; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Author>()
            .HasOne(a => a.Biography)
            .WithOne(b => b.Author)
            .HasForeignKey<AuthorBiography>(b => b.AuthorId);

            modelBuilder.Entity<AuthorBiography>()
            .HasKey(k => k.Id);

            modelBuilder.ApplyConfiguration(new AuthorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PostEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CommentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ContactEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AboutEntityTypeConfiguration());

        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }

        #region databse models

        // REMOVE ME
        //public DbSet<Book> Book { get; set; }
        //public DbSet<Author1> Author { get; set; }

        //// Until ME

        //public DbSet<About> Abouts { get; set; }
        //public DbSet<Post> Blogs { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Author> Writers { get; set; }
        #endregion
    }
}
