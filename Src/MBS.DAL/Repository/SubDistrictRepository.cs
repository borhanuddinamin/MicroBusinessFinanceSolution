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
    public class SubDistrictRepository : Repository<SubDistrict>, ISubDistrictRepository
    {
        private ApplicationDbContext _db;
        public SubDistrictRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
       

        public void Update(SubDistrict obj)
        {
            var objFromDb = _db.SubDistricts.FirstOrDefault(x => x.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.SubDistrictName = obj.SubDistrictName;
                objFromDb.DistrictId = obj.DistrictId;
                objFromDb.DivisionId = obj.DivisionId;
                
            }
            }
    }
}
