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
    public class StockRepository:Repository<Stock>,IStockRepository
    {
        private readonly ApplicationDbContext _db;
        public StockRepository(ApplicationDbContext db):base(db) 
        {
            _db= db;
        }

        public void Update(Stock obj)
        {
            if (obj != null)
            {
                _db.Stocks.Update(obj);
            }

            

            //var stockProductId = _db.Stocks.FirstOrDefault(x => x.ProductId == obj.ProductId);
            //var purchaseItem = _db.PurchaseItems.FirstOrDefault(x => x.ProductId == stockProductId.ProductId);
            //var saleItem = _db.PurchaseItems.FirstOrDefault(x => x.ProductId == stockProductId.ProductId);
            //var purchaseQty = purchaseItem.Quantity;
            //var saleQty = saleItem.Quantity;
            //if (purchaseQty != 0) 
            //{
            //  //stockProductId.PurchaseItem =(float)purchaseQty ;
            // // stockProductId.RunningStock +=(float)purchaseQty ;
                

            //}
            //if (saleItem.ProductId!=0)
            //{
            //   // stockProductId.RunningStock -= (float)saleQty;
            //}

            


        }
    }
}
