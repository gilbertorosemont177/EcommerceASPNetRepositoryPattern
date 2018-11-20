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
            var listeproduitscomplete = ConnexionRepositories.GetConnexionRepositories().articles.GetAll().ToList();
            var listeviewmodel = new ViewModelsArticlesCategories
            {
               categorieMagasin = listecategories,
               articlesMagasin = listeproduitscomplete,

            };
           
            return View(listeviewmodel);
        }
        [HttpPost]
        public ActionResult Index(string categorienom)

        {
            if (categorienom.Equals(""))
            {
                return RedirectToAction("Index", "MagasinHome");
            }
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

      
        public ActionResult articlesbycategory(string nom)
        {
            var listearticlesbycategories = ConnexionRepositories.GetConnexionRepositories().articles.getALLArticlesbyCategorie(nom);
            
            var listeviewmodel = new ViewModelsArticlesCategories
            {
                
                articlesMagasin = listearticlesbycategories
            };
            var gt = listeviewmodel;
            return View( listeviewmodel);

            
        }
        public ActionResult searcharticle(string nomarticle)
        {
            var liste = ConnexionRepositories.GetConnexionRepositories().articles.getItemsbyName(nomarticle);
            ViewBag.itemnom = nomarticle;
            var viewmodel = new ViewModelsArticlesCategories
            {
                articlesMagasin = liste
            };
            return View(viewmodel);
        }
    }
}