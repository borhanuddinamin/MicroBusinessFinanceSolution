using MBS.Application.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected  DbContext _context { get; set; }

        public UnitOfWork(DbContext dbContext)
        {
            _context = dbContext;
        }
        public virtual void Dispose()
        {
            _context?.Dispose();
        }

        public virtual   void Save()
        {
            _context?.SaveChanges();
        }
    }
}
