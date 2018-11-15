﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCnX.DbEntityFramework;
using DatabaseCnX.Core.Repositories;
using System.Data.Entity;

namespace DatabaseCnX.PersistanceData.RepositoriesModels
{
    public class ArticleRepository :Repository<ARTICLE> ,IArticleRepository
    {
        public ArticleRepository(DbContext dbc) : base(dbc)
        {
        }
    }
}