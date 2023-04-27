using DesignPattern.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.UnitOfWork
{
    public class UowDal : IUowDal
    {
        private readonly Context _context;
        public UowDal(Context context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
