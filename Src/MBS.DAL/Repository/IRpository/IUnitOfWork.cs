using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository.IRpository
{
    public interface IUnitOfWork
    {
        public ICategoryRepository Category { get;}
        public IProductRepository Product { get;}
        public IBrandRepository Brand { get;}
        public IUnitRepository Unit { get;}
        public ICustomerRepository Customer { get;}
        public ISupplierRepository Supplier { get;}
        public IPurchaseRepository Purchase { get;}
        public IDamageRepository Damage { get;}
        public IStockRepository Stock { get;}
        public IProductModelRepository ProductModel { get;}
        public IPurchaseInvoiceRepository PurchaseInvoice { get;}
        public IDivisionRepository Division { get;}
        public IUserDivisionRepository UserDivision { get;}
        public IDistrictRepository District { get;}
        public ISubDistrictRepository SubDistrict { get;}
        public ILocationRepository Location { get;}
      
        void Save();
    }
}
