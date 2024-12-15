using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CustomerDal : ICustomerDal
    {
        private readonly Context _context;

        public CustomerDal(Context context)
        {
            _context = context;
        }

        public void Delete(Customer p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Insert(Customer p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void Update(Customer p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}
