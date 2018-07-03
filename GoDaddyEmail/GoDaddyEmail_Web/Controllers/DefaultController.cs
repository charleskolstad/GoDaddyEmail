using GoDaddyEmail_Core;
using GoDaddyEmail_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoDaddyEmail_Web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel model)
        {
            string errorMessage = string.Empty;
            EmailManager.SendEmail(model, out errorMessage);

            if (string.IsNullOrEmpty(errorMessage) == false)
                ViewBag.ErrorMessage = errorMessage;

            return View();
        }
    }
}