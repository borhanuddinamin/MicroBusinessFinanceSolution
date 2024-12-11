using MBS.Models;
using MBS.Models.EntityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace MBS.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<PurchasePayment> PurchasePayments { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesItem> SalesItem { get; set; }
        public DbSet<Damage> Damages { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<Division> Divisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            // Define primary keys
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });



            modelBuilder.Entity<Division>().HasData(
                new Division { Id = 1, Division_EngName = "Chattagram", Division_BanName = "চট্টগ্রাম"},
                new Division { Id = 2, Division_EngName = "Rajshahi", Division_BanName = "রাজশাহী" },
                new Division { Id = 3, Division_EngName = "Khulna", Division_BanName = "খুলনা" },
                new Division { Id = 4, Division_EngName = "Barishal", Division_BanName = "বরিশাল" },
                new Division { Id = 5, Division_EngName = "Sylhet", Division_BanName = "সিলেট" }, 
                new Division { Id = 6, Division_EngName = "Dhaka", Division_BanName = "ঢাকা" },
                new Division { Id = 7, Division_EngName = "Rangpur", Division_BanName = "রংপুর" },
                new Division { Id = 8, Division_EngName = "Mymensingh", Division_BanName = "ময়মনসিংহ"}
               
         
            );



    }
    }
}
