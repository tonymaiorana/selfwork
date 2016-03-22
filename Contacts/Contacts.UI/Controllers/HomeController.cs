using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contacts.Data;
using Contacts.Models;

namespace Contacts.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = new MockContactRepository();
            var contacts = repo.GetAll();

            return View(contacts);
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            int contactID = int.Parse(Request.Form["ContactID"]);

            var repo = new MockContactRepository();
            repo.Delete(contactID);

            var contacts = repo.GetAll();
            return View("Index", contacts);
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View("AddContact");
        }
    }
}