using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseCnX.PersistanceData.RepositoryData;

namespace EcommerceEntityFrameWorkRepositoryPattern.Controllers
{
    public class MagasinHomeController : Controller
    {
        // GET: MagasinHome
        public ActionResult Index()
        {
            var listeArticles = ConnexionRepositories.GetConnexionRepositories().articles.GetAll();
            return View();
        }
    }
}