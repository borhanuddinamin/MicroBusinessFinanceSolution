using MBS.Models;
using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository.IRpository
{
    public interface IPurchaseRepository : IRepository<Purchase>
    { 
        void Update(Purchase obj);

        List<PurchaseItem> GetPurchaseItems(int PurchaseId);
    }
}
