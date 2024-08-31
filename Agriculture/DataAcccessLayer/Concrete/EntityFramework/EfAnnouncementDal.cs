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
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public EfAnnouncementDal(Context context) : base(context)
        {
        }
    }
}
