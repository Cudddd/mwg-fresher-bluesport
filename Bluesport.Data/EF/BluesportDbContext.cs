using Bluesport.Data.Configurations;
using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bluesport.Data.EF
{
    public class BluesportDbContext : DbContext
    {
        public BluesportDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new BrandsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImagesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionsConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMapCateConfiguration());
            modelBuilder.ApplyConfiguration(new SizesConfiguration());
            modelBuilder.ApplyConfiguration(new ColorsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMapSizeConfiguration());
            modelBuilder.ApplyConfiguration(new SizeMapColorConfiguration());
            modelBuilder.ApplyConfiguration(new BannersConfiguration());
            modelBuilder.ApplyConfiguration(new BannerTypesConfiguration());
            modelBuilder.ApplyConfiguration(new ContactsConfiguration());
            modelBuilder.ApplyConfiguration(new TopicsConfiguration());
            
            
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Banners> Banners { get; set; }
        public DbSet<BannerTypes> BannerTypes { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductMapCate> ProductMapCate { get; set; }
        public DbSet<ProductMapSize> ProductMapSize { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Promotions> Promotions { get; set; }
        public DbSet<SizeMapColor> SizeMapColor { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<PromotionDetails> PromotionDetails { get; set; }
    }
}