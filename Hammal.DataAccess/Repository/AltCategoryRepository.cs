﻿using Hammal.DataAccess.Repository;
using Hammal.DataAccess.Data;
using Hammal.DataAccess.Repository.IRepository;
using Hammal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammal.DataAccess.Repository
{
    public class AltCategoryRepository : Repository<AltCategory>, IAltCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public AltCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Advertisement obj)
        {
            _db.Update(obj);  
        }
    }
}
