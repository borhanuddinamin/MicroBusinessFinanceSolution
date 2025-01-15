using MBS.Models.EntityModel.UserAddress;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.EntityModel
{
    public class Location:BaseEntity
    {
        public int SubDistrictId { get; set; }
        [ForeignKey("SubDistrictId")]
        public SubDistrict? SubDistrict { get; set; }

        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District? District { get; set; }

        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public UserDivision? Division { get; set; }

        public string UserID { get; set; }
    }
}
