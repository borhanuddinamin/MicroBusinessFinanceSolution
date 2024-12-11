using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Product")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        public bool IsActive { get; set; }=false;
        public bool IsArrival { get; set; }=false;
        public bool IsLatest { get; set; } = false;
        public bool IsBestSaling { get; set; } = false;
        public bool IsLowStock { get; set; } = false;
    }
}
