using common;
using danjukaipiao.App_Start;
using danjukaipiao.Authorize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace danjukaipiao.Controllers
{
    [MvcAuthorize]
    public class HomeController : Controller
    {
        [MyFilter]
        public ActionResult Index()
        {
                ViewBag.Title = "主页";
                return View();
        }
        public ActionResult yuzhi()
        {
            
            return View();
        }
        public ActionResult baoxiao()
        {
          
            return View();
        }
        public ActionResult shenpi()
        {
            return View();
        }
        public ActionResult chailvfei()
        {
            return View();
        }
        public ActionResult error()
        {
            return View();
        }
    }
}
