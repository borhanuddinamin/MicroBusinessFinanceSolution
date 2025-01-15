using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using MBS.Models.EntityModel.UserAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository
{
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        private ApplicationDbContext _db;
        public DistrictRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
       

        public void Update(District obj)
        {
            var objFromDb = _db.Districts.FirstOrDefault(x => x.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.DistrictName = obj.DistrictName;
                objFromDb.DivisionId = obj.DivisionId;
                
               
            }
            }
    }
}
