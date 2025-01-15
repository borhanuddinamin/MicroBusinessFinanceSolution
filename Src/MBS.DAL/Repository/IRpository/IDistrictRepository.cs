using MBS.Models.EntityModel;
using MBS.Models.EntityModel.UserAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository.IRpository
{
    public interface IDistrictRepository : IRepository<District>
    {
        
        void Update(District obj);
    }
}
