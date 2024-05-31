using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal
    {
        void Insert(Product p);

        void Update(Product p);

        void Delete(Product p);

        List<Product> GetAll();
    }
}
