using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository
{
    public class DivisionRepository : Repository<Division>, IDivisionRepository
    {
        private ApplicationDbContext _db;
        public DivisionRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
       

        public void Update(Division obj)
        {
            _db.Divisions.Update(obj);
        }
    }
}
