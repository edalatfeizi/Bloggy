﻿using DataAccessLayer.Abstraction;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Author>, IWriterDal
    {
        public EfWriterRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
