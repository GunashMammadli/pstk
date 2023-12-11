using Microsoft.EntityFrameworkCore;
using Pustok0.Models;
using System.Drawing;

namespace Pustok0.Context
{
    public class PustokDbContext : DbContext
    {
        public PustokDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductAuthor> ProductAuthors { get; set; }
    }
}
