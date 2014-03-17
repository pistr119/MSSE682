using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OLAPManager.Models.Domain;

namespace OLAPManager.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //References
        //Freeman, A. (2013). Pro ASP.NET MVC 5. New York, NY: Apress.
        //

        public ViewResult Index()
        {
            return View();  //borrowed from ASP.NEt MVC 5 Pro, by Adam Freeman, page 19
        }

        [HttpGet] //Freeman, p34
        public ViewResult RequestAccess()
        {
            return View();
        }
        //

        //
        [HttpPost]
        public ViewResult RequestAccess(RequestAccess request)
        {
            if(ModelState.IsValid) //freeman, p37
                //TODO:  business layer validations ?
            return View("Thank you for your submission", request.SubmittedByUser.ToString());

            else
            {

                return View();
            }
        }
        //
        [HttpGet]
        public ViewResult ReportBug()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult ReportBug (RequestBug request)
        {
            return View("Thank you for your submission", request.SubmittedByUser.ToString());
        }
        //


        [HttpGet]
        public ViewResult RequestChange()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RequestChange(RequestChange request)
        {
            return View("Thank you for your submission", request.SubmittedByUser.ToString());
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}