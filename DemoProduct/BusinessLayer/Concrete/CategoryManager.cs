using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryDal
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
           return _categoryDal.GetList();
        }

        public void Insert(Category t)
        {
           _categoryDal.Insert(t);
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
