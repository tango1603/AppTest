using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppTest.Models;

namespace AppTest.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        AddressContext db = new AddressContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Address> addreses = db.Addreses;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Addreses = addreses;
            // возвращаем представление
            return View();
        }

    }
}