using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class IProductService : IGenericService<Product>
    {
        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Product t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
