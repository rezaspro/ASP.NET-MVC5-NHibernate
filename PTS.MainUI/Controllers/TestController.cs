using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using NHibernate;
using PTS.BusinessModel;
using PTS.BusinessModel.Models;
using PTS.Service;
using PTS.Service.Helper;

namespace PTS.MainUI.Controllers
{
    public class TestController : Controller
    {
        private ISession sessionFactory;
        private ICategoryService _testService;

        public TestController()
        {
            string mvcVersion = typeof(Controller).Assembly.GetName().Version.ToString();
            sessionFactory = NHibernateHelper.OpenSession();
            _testService = new CategoryService(sessionFactory);
        }
        // GET: Test
        public ActionResult Index()
        {
            //AppUser appUser=new AppUser();
            //appUser.Name = "Test User";
            //var user=_testService.Save(appUser);
            //ViewBag.User = "SFAL";
            return View();
        }

        [HttpGet]
        public ActionResult CategorySave()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CategorySave(Category category)
        {
            _testService.Save(category);
            return View();
        }

        [HttpGet]
        public ActionResult ProductSave()
        {
            var categories = _testService.LoadCategory();
            ViewBag.Category = new SelectList(categories, "Id", "Name"); ;
           
           // _testService.Save(product);
            return View();
        }

        [HttpPost]
        public ActionResult ProductSave(Product product)
        {
            // _testService.Save(product);
            return View();
        }
    }
}