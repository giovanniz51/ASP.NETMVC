using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Index()
        {
            return Content("Comicbooks Index");
        }

        // comicbooks/detail
        public ActionResult Detail()
        {


            return View();
        }
    }
}