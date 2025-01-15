using MBS.Models;
using MBS.Models.EntityModel;
using MBS.Models.EntityModel.UserAddress;
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
        public DbSet<Location> Locations { get; set; }
        public DbSet<UserDivision> UserDivisions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<SubDistrict> SubDistricts { get; set; }
        
        

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

            modelBuilder.Entity<UserDivision>().HasData(
          new UserDivision { Id = 1, DivisionName = "Chattagram" },
          new UserDivision { Id = 2, DivisionName = "Rajshahi" },
          new UserDivision { Id = 3, DivisionName = "Khulna" },
          new UserDivision { Id = 4, DivisionName = "Barishal" },
          new UserDivision { Id = 5, DivisionName = "Sylhet" },
          new UserDivision { Id = 6, DivisionName = "Dhaka" },
          new UserDivision { Id = 7, DivisionName = "Rangpur" },
          new UserDivision { Id = 8, DivisionName = "Mymensingh" }


      );

            modelBuilder.Entity<District>().HasData(
         new District { Id = 1, DistrictName = "Chattagram", DivisionId = 1 },
         new District { Id = 2, DistrictName = "Rajshahi", DivisionId = 2 },
         new District { Id = 3, DistrictName = "Khulna", DivisionId = 3 },
         new District { Id = 4, DistrictName = "Barishal", DivisionId = 4 },
         new District { Id = 5, DistrictName = "Sylhet", DivisionId = 5 },
         new District { Id = 6, DistrictName = "Dhaka", DivisionId = 6 },
         new District { Id = 7, DistrictName = "Rangpur", DivisionId = 7 },
         new District { Id = 8, DistrictName = "Mymensingh", DivisionId = 8 },

         new District { Id = 9, DistrictName = "Noakhali", DivisionId = 1 },
         new District { Id = 10, DistrictName = "Coxbazar", DivisionId = 1 },

         new District { Id = 11, DistrictName = "Pabna", DivisionId = 2 },
         new District { Id = 12, DistrictName = "Nator", DivisionId = 2 },

         new District { Id = 13, DistrictName = "Jashore", DivisionId = 3 },
         new District { Id = 14, DistrictName = "Magura", DivisionId = 3 },

         new District { Id = 15, DistrictName = "MusnshiGanj", DivisionId = 5 },
         new District { Id = 16, DistrictName = "ManikGanj", DivisionId = 5 }


     );


            modelBuilder.Entity<SubDistrict>().HasData(
             new SubDistrict { Id = 1, SubDistrictName = "Chattagram_sadar", DivisionId = 1, DistrictId = 1 },
             new SubDistrict { Id = 2, SubDistrictName = "Rajshahi_sadar", DivisionId = 2, DistrictId = 2 },
             new SubDistrict { Id = 3, SubDistrictName = "Khulna_sadar", DivisionId = 3, DistrictId = 3 },
             new SubDistrict { Id = 4, SubDistrictName = "Barishal_sadar", DivisionId = 4, DistrictId = 4 },
             new SubDistrict { Id = 6, SubDistrictName = "Dhaka_sadar", DivisionId = 6, DistrictId = 6 },


             new SubDistrict { Id = 7, SubDistrictName = "Monirampur", DivisionId = 3, DistrictId = 13 },
             new SubDistrict { Id = 8, SubDistrictName = "Avainagar", DivisionId = 3, DistrictId = 13 },

             new SubDistrict { Id = 9, SubDistrictName = "Shalikha", DivisionId = 3, DistrictId = 14 },
             new SubDistrict { Id = 10, SubDistrictName = "Mohammadpur", DivisionId = 3, DistrictId = 14 }




         );


        }
    }
}
