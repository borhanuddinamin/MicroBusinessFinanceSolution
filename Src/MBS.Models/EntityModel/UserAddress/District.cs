using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel.UserAddress
{
    public class District:BaseEntity
    {
        public string  DistrictName { get; set; }
        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public UserDivision? Division { get; set; }

    }
}
