using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Controllers;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Tests.Controller
{
    [TestClass]
    public class UnitTest1
    {
        HomeController con;

        [TestInitialize]
        public void Init()
        {
            con = new HomeController();
        }

        [TestMethod]
        public void Sequence_01()
        {
            ViewResult res = con.Index(5) as ViewResult;
            string exp = "1, 2, 3, 4, 5";
            string act = res.ViewBag.Sequence_01;
            Assert.AreEqual(exp, act);

        }

        [TestMethod]
        public void Sequence_02()
        {
            ViewResult res = con.Index(9) as ViewResult;
            string exp = "1, 3, 5, 7, 9";
            string act = res.ViewBag.Sequence_02;
            Assert.AreEqual(exp, act);

        }

        [TestMethod]
        public void Sequence_03()
        {
            ViewResult res = con.Index(10) as ViewResult;
            string exp = "2, 4, 6, 8, 10";
            string act = res.ViewBag.Sequence_03;
            Assert.AreEqual(exp, act);

        }

        [TestMethod]
        public void Sequence_04()
        {
            ViewResult res = con.Index(15) as ViewResult;
            string exp = "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z";
            string act = res.ViewBag.Sequence_04;
            Assert.AreEqual(exp, act);

        }

        [TestMethod]
        public void Sequence_05()
        {
            ViewResult res = con.Index(15) as ViewResult;
            string exp = "1, 1, 2, 3, 5, 8, 13";
            string act = res.ViewBag.Sequence_05;
            Assert.AreEqual(exp, act);

        }
    }
}
