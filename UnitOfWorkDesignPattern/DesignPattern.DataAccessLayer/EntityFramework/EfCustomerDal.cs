using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {

        }
    }
}
