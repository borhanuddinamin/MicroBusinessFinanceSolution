using MBS.Models.EntityModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Web.Mvc;

namespace MBS.UI.Models.ClientVM
{
    public class HomePageVM
    {
        [ValidateNever]
        public List<ProductModel>? ActiveProductList { get; set; }

        [ValidateNever]
        public List<ProductModel>? LatestProductList { get; set; }

        [ValidateNever]
        public List<Category>? CategoryList { get; set; }

        //[ValidateNever]
        //public IEnumerable<SelectListItem>? LatestProductList { get; set; }

        //[ValidateNever]
        //public IEnumerable<SelectListItem>? BestProductList { get; set; }
    }
}
