using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using giftList.Models;
using giftList.ViewModels;


namespace giftList.Controllers
{
    public class GiftController : Controller
    {
        // GET: Gift/ Random
        public ActionResult Random()
        {
            var gift = new Gift() { Name = "Disney Doll"};

            var wishers = new List<Wisher>
            {
                new Wisher {Name = "Wisher 1 "},
                new Wisher {Name = "Wisher 2"}
            };

            var viewModel = new RandomGiftViewModel
            {
                Gift = gift,
                Wishers = wishers
            };
           
            return View(viewModel);

            //return Content("Hello World");
        }
       // [Route("gift/released/{year}/{month: regex(\\d{4}): range(1, 12)}")]

       /* public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year+"/" + month);
        }*/
       
    }
}