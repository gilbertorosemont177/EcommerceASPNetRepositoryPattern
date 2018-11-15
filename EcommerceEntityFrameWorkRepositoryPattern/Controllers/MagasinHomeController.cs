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
            //var listeviwmodel = new ViewModelsArticlesCategories
            //{
            //    categorieMagasin = listecategories,
            //    articlesMagasin = null

            //};
           
            return View(listecategories);
        }
        //public ActionResult Index(string c)
        //{

        //    return View("Index",)
        //}
    }
}