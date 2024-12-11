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
    public class PurchaseInvoiceRepository : Repository<PurchaseInvoice>, IPurchaseInvoiceRepository
    {
        private ApplicationDbContext _db;
        public PurchaseInvoiceRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
       

        public void Update(PurchaseInvoice obj)
        {
            _db.PurchaseInvoices.Update(obj);
        }
    }
}
