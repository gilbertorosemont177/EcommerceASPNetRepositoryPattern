using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseCnX.PersistanceData.RepositoryData;
using EcommerceEntityFrameWorkRepositoryPattern.Models;


namespace EcommerceEntityFrameWorkRepositoryPattern.Controllers
{
    public class MagasinHomeController : Controller
    {
        // GET: MagasinHome
        public ActionResult Index()
        {
            var listecategories = ConnexionRepositories.GetConnexionRepositories().categorie.GetAll().ToList();
            var listeviewmodel = new ViewModelsArticlesCategories
            {
               categorieMagasin = listecategories,
               articlesMagasin = null

            };
           
            return View(listeviewmodel);
        }
        [HttpPost]
        public ActionResult Index(string categorienom)
        {
            var listearticlesbycategories = ConnexionRepositories.GetConnexionRepositories().articles.getALLArticlesbyCategorie(categorienom);
            var listecategories = ConnexionRepositories.GetConnexionRepositories().categorie.GetAll().ToList();

            var listeviewmodel = new ViewModelsArticlesCategories
            {
                categorieMagasin = listecategories,
                articlesMagasin = listearticlesbycategories
        };
            var gt = listeviewmodel;
            return View("Index",listeviewmodel);
        }
    }
}