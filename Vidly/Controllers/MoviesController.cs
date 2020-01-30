using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    //scaffolding = autogenerating some code
    public class MoviesController : Controller
    {
        // GET: Movies
        //view result is one of the action results that you work with most of the time 
        //Action results:
         //ViewResult          - returns a -           view
         //PartialViewResult                           partial view                   
         //ContentResult                               simple text
         //RedirectResult                              redirect an user to an URL
         //RedirectToRouteResult                       redirect an Action instead of URL
         //JsonResult                                  serialized json object
         //FileResult                                  file
         //HttpNotFoundResult                          404 error
         //EmptyResult                                 ~ void. the action doesn't need to return any value
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //to make a parameter optional we should make it nullable
        //reference types are nullable -> For example, you can assign any of the following three values to a bool? variable: true, false, or null.
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy= "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}