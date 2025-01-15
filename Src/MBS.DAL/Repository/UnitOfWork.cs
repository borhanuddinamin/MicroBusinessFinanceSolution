using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using MBS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Brand = new BrandRepository(_db);
            Unit = new UnitRepository(_db);
            Customer = new CustomerRepository(_db);
            Supplier = new SupplierRepository(_db);
            Purchase = new PurchaseRepository(_db);
            Damage = new DamageRepository(_db);
            Stock = new StockRepository(_db);
            ProductModel = new ProductModelRepository(_db);
            PurchaseInvoice = new PurchaseInvoiceRepository(_db);
            Division = new DivisionRepository(_db);
            UserDivision = new UserDivisionRepository(_db);
            District = new DistrictRepository(_db);
            SubDistrict = new SubDistrictRepository(_db);
            Location = new LocationRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IBrandRepository Brand { get; private set; }
        public IUnitRepository Unit { get; private set; }
        public ICustomerRepository Customer { get; private set; }
        public ISupplierRepository Supplier { get; private set; }
        public IPurchaseRepository Purchase { get; private set; }
        public IDamageRepository Damage { get; private set; }
        public IStockRepository Stock { get; private set; }
        public IProductModelRepository ProductModel { get; private set; }
        public IPurchaseInvoiceRepository PurchaseInvoice { get; private set; }
        public IDivisionRepository Division { get; private set; }
        public IUserDivisionRepository UserDivision { get; private set; }
        public IDistrictRepository District { get; private set; }
        public ISubDistrictRepository SubDistrict { get; private set; }
        public ILocationRepository Location { get; private set; }
      

        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
