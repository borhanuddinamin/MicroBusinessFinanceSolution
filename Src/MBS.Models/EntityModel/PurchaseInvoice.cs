using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel
{
    public class PurchaseInvoice:BaseEntity
    {
        public string InvoiceName { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceUrl { get; set; }
    }
}
