using Microsoft.AspNetCore.Mvc.Rendering;
using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.AppVM
{
    public class UnitVM
    {
        public Unit Unit { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? UnitList { get; set; }
    }
}
