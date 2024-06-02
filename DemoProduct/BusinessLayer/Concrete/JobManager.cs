using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    internal class JobManager : IJobDal
    {
        private readonly IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void Delete(Job t)
        {
           _jobDal.Delete(t);
            
        }

        public Job GetById(int id)
        {
           var values = _jobDal.GetById(id);    
            return values;
        }

        public List<Job> GetList()
        {
         ;
            return _jobDal.GetList();
        }

        public void Insert(Job t)
        {
           _jobDal.Insert(t);

        }

        public void Update(Job t)
        {
            _jobDal.Update(t);
        }
    }
}
