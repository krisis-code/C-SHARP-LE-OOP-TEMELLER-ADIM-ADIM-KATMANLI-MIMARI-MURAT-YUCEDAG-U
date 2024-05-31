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
        private readonly Context context;

        public ProductDal(Context _context)
        {
            context = _context;
        }

       
        public void Delete(Product p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
           return context.Products.ToList();
        }

        public void Insert(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void Update(Product p)
        {
          context.Update(p);
            context.SaveChanges();
        }
    }
}
