using BusinessLayer.Abstract;
using DataAcccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public Task TDeleteAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task<T> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TInsertAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(T t)
        {
            throw new NotImplementedException();
        }
    }
}
