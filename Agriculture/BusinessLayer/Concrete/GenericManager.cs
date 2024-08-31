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

        public async Task TDeleteAsync(T t)
        {
          await _genericDal.DeleteAsync(t);
        }

        public async Task<T> TGetByIdAsync(int id)
        {
            return await _genericDal.GetByIdAsync(id);
        }

        public Task<List<T>> TGetListAsync()
        {
            return _genericDal.GetListAsync();
        }

        public async Task TInsertAsync(T t)
        {
            await _genericDal.InsertAsync(t);

        }

        public async Task TUpdateAsync(T t)
        {
            await _genericDal.UpdateAsync(t);
        }
    }
}
