using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCnX.Core.Repositories;
using DatabaseCnX.Core;
using DatabaseCnX.DbEntityFramework;
using DatabaseCnX.PersistanceData.RepositoriesModels;

namespace DatabaseCnX.PersistanceData
{
    public class UnityOfWork : IUnitOfWork
    {
        private readonly ecommerceEntities _ecommercerContext= new ecommerceEntities();
        
      

        public IArticleRepository articles => new ArticleRepository(_ecommercerContext);

        public ICategorieRepository categorie => new CategoriesRepository(_ecommercerContext);

        public IProfilRepository profil => new ProfilRepository(_ecommercerContext);

        public IUserReposiroy user=> new UserRepository(_ecommercerContext);

        public IQuestionSecrets questions => new QuestionSecretRepository(_ecommercerContext);

        public void SaveChanges()
        {
            _ecommercerContext.SaveChanges();
        }

        public void Dispose()
        {
            _ecommercerContext.Dispose();
            
        }
    }
}
