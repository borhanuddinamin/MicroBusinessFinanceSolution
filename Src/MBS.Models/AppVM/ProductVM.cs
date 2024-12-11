using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.AppVM
{
    public class ProductVM
    {
        public Product Product { get; set; }
         
        [ValidateNever]
        public IEnumerable<SelectListItem>? CategoryList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? UnitList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? BrandList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? SubUnitList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem>? DivisionList { get; set; }

        public Unit? SubUnit { get; set; }
    }
}
