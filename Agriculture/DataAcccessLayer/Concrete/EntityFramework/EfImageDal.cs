﻿using DataAcccessLayer.Abstract;
using DataAcccessLayer.Concrete.Repository;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcccessLayer.Concrete.EntityFramework
{
    public class EfImageDal : GenericRepository<Image>,IImageDal
    {
    }
}
