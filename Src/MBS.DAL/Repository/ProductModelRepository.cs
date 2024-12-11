using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository
{
    public class ProductModelRepository : Repository<ProductModel>, IProductModelRepository
    {
        private ApplicationDbContext _db;
        public ProductModelRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
       

        public void Update(ProductModel obj)
        {
            _db.ProductModels.Update(obj);
        }
    }
}
