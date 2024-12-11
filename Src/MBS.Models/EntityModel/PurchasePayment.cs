using MBS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel
{
    public class PurchasePayment : BaseEntity
    {
        public int? PurchaseId { get; set; }

        public DateTime? PaymentDate { get; set; }

        public TransactionAccount? TransactionAccount { get; set; }

        public double? PaymentAmount { get; set; }
    }
}
