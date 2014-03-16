using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLAPManager;
using OLAPManager.Controllers;

namespace OLAPManager.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ViewTestIndex()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ViewTestAbout()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void ViewTestContact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RequestAccessTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.RequestAccess() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RequestBugTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.ReportBug() as ViewResult;
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void RequestChangeTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.RequestChange() as ViewResult;
            Assert.IsNotNull(result);
        }





    }
}
