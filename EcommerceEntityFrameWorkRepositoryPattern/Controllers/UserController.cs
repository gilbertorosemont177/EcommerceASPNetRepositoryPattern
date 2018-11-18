using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseCnX.DbEntityFramework;

using DatabaseCnX.PersistanceData.RepositoryData;

namespace EcommerceEntityFrameWorkRepositoryPattern.Controllers
{
    public class UserController : Controller
    {
        // GET: User
       
        public ActionResult Index()
        {
            var question = ConnexionRepositories.GetConnexionRepositories().questions.Get(7);

       
            return View(question);
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}