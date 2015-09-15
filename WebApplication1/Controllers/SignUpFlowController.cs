using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arbejdarbejd.Controllers
{
    public class SignUpFlowController : Controller
    {
        //
        // GET: /SignUpFlow/
        public ActionResult Step1()
        {
            return View();
        }

        public ActionResult Step2()
        {
            var Model = new Arbejdarbejd.Models.UserModel();
            Model.Email = Request.Form["email"].ToString();

            return View(Model);
        }

        public ActionResult Step3()
        {
            return View();
        }
	}
}