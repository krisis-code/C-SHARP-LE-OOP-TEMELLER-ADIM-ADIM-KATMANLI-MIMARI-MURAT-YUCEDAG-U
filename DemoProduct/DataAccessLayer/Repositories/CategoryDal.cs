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
    public class CategoryDal : ICategoryDal
    {
        private readonly Context _context;

        public CategoryDal(Context context)
        {
            _context = context;
        }

        public void Delete(Category p)
        {
           _context.Remove(p);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public void Insert(Category p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void Update(Category p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}
