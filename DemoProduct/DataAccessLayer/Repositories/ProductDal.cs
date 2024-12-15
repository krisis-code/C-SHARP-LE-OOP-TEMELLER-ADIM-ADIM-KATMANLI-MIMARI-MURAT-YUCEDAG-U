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
    public class ProductDal : IProductDal
    {
        private readonly Context _context;

        public ProductDal(Context context)
        {
            _context = context;
        }

       
        public void Delete(Product p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
           return _context.Products.ToList();
        }

        public void Insert(Product p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void Update(Product p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}
