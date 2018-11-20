using System;
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

        

        public List<ARTICLE> getALLArticlesbyCategorie(string ctgrnom)
        {
            var liste = this.Context.Set<ARTICLE>().Where(ctg => ctg.categorienom == ctgrnom).ToList();
            return liste;
        }
        public List<ARTICLE> getItemsbyName(string item) {
            var context = this.Context as ecommerceEntities;
          
            var collectionitems = context.SelectAllProduitsbyModel(item).ToList() ;
            List<ARTICLE> collectionArticles = new List<ARTICLE>();
            if (collectionitems.Count > 0)
            {
                foreach (var items in collectionitems)
                {
                    ARTICLE article = new ARTICLE();
                    article.idarticle = items.idarticle;
                    article.prix = items.prix;
                    article.quantite = items.quantite;
                    article.img = items.img;
                    article.categorienom = items.categorienom;
                    article.datecreation = items.datecreation;
                    article.marque = items.marque;
                    article.model = items.model;
                    collectionArticles.Add(article);

                }
                
            }

            return collectionArticles ;
        }
    }
}
