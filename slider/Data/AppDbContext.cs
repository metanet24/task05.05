using Microsoft.EntityFrameworkCore;
using slider.Models;

namespace slider.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<AboutSuprise> AboutSuprise { get; set; }
        public DbSet<SupriseText> SupriseTexts { get; set; }
        public DbSet<Expert> Experts { get; set; }







    }
}
