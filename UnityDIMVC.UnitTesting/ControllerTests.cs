using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnityDIMVC;
using UnityDIMVC.Controllers;

namespace UnityDIMVC.UnitTesting
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void Index()
        {
            HomeController hc = new HomeController();
            ViewResult vr = hc.Index() as ViewResult;
            Assert.IsNotNull(vr);
        }

        [TestMethod]
        public void About()
        {
            HomeController hc = new HomeController();
            ViewResult vr = hc.About() as ViewResult;
            Assert.IsNotNull(vr);
        }
    }
}
