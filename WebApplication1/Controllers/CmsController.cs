using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arbejdarbejd.Controllers
{
    public class CmsController : Controller
    {
        //
        // GET: /Cms/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Texts()
        {
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Texts(FormCollection _formCollection)
        {
            WebApplication1.Models.ArbejdArbejdDBDataContext db = new WebApplication1.Models.ArbejdArbejdDBDataContext();
            var item = db.aaTexts.Where(i => i.TextName == Request["textId"].ToString()).SingleOrDefault();
            item.TextContent = _formCollection["editor1"].ToString();

            db.SubmitChanges();

            return View();
        }
	}
}