using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        private readonly Context _context;
        public EfCustomerDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Customer> GetCustomerListWithJob()
        {
           return _context.Customers.Include(x=>x.Job).ToList();
        }
    }
}
