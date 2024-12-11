using MBS.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository.IRpository
{
    public interface IUnitRepository : IRepository<Unit>
    {

        void Update(Unit obj);
    }
}
