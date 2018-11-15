using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseCnX.DbEntityFramework;

namespace EcommerceEntityFrameWorkRepositoryPattern.Models
{
    public class ViewModelsArticlesCategories
    {
        public IEnumerable<ARTICLE> articlesMagasin { get; set; }
        public IEnumerable<CATEGORIE> categorieMagasin { get; set; }
    }
}