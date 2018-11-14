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
        private readonly ecommerceEntities _ecommercerContext;
        public UnityOfWork(ecommerceEntities context)
        {
            _ecommercerContext = context;
            articles = new ArticleRepository(_ecommercerContext);
            categorie = new CategoriesRepository(_ecommercerContext);
            profil = new ProfilRepository(_ecommercerContext);
            user = new UserRepository(_ecommercerContext);
            questions = new QuestionSecretRepository(_ecommercerContext);

        }


        public IArticleRepository articles { get; private set; }

        public ICategorieRepository categorie { get; private set; }

        public IProfilRepository profil { get; private set; }

        public IUserReposiroy user { get; private set; }

        public IQuestionSecrets questions { get; private set; }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
