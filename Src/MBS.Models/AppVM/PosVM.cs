
using Microsoft.AspNetCore.Mvc.Rendering;
using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace MBS.Models.AppVM
{
    public class PosVM
    {
        public Sales Pos { get; set; }
        public Product Product { get; set; }
        [ValidateNever]
       
        public IEnumerable<SelectListItem>? ProductList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? CustomerList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? CategoryList { get; set; }

    }
}
