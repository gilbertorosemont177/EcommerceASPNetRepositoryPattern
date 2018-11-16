using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCnX.DbEntityFramework;

namespace DatabaseCnX.Core.Repositories
{
   public interface IArticleRepository : IRepository<ARTICLE> 
    {

        List<ARTICLE> getALLArticlesbyCategorie(string ctgrnom);
    }

   
}
