using Microsoft.EntityFrameworkCore;
using FrontToBack.Models;

namespace FrontToBack.Contexts
{
    public class ProniaDbContext : DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {
        }

        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Shipping>? Shippings { get; set; }
    }
}