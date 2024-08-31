using DataAcccessLayer.Abstract;
using DataAcccessLayer.Concrete.Repository;
using DataAccessLayer.Concrete;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcccessLayer.Concrete.EntityFramework
{
    public class EfTeamDal : GenericRepository<Team>, ITeamDal
    {
        public EfTeamDal(Context context) : base(context)
        {
        }
    }
}
