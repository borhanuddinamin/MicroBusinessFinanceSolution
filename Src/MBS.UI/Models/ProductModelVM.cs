using MBS.Models.EntityModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MBS.UI.Models
{
    public class ProductModelVM
    {
        public ProductModel ProductModel { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem>? ProductList { get; set; }
    }
}
