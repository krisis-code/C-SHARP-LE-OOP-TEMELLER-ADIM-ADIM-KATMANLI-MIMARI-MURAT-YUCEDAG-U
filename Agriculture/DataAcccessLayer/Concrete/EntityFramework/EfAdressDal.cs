﻿using DataAcccessLayer.Abstract;
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
    public class EfAdressDal : GenericRepository<Adress>, IAdressDal
    {
        public EfAdressDal(Context context) : base(context)
        {
        }
    }
}
