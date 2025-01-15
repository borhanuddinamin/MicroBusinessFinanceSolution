using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel.UserAddress
{
    public class SubDistrict:BaseEntity
    {
        public string SubDistrictName { get; set; }

        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District? District { get; set; }

        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public UserDivision? Division { get; set; }
    }
}
