using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using giftList.Models;

namespace giftList.Controllers
{
    public class GiftController : Controller
    {
        // GET: Gift/ Random
        public ActionResult Random()
        {
            var gift = new Gift() { Name = "Disney Doll"};

            var viewResult = new ViewResult();
           
            return View(gift);
            //return Content("Hello World");
        }
       // [Route("gift/released/{year}/{month: regex(\\d{4}): range(1, 12)}")]

       /* public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year+"/" + month);
        }*/
       
    }
}