using NumericSequenceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int number = 0)
        {
            Sequence seq = new Sequence(number);
            seq.Calculate();
            ViewBag.Sequence_01 = seq.Sequence_01;
            ViewBag.Sequence_02 = seq.Sequence_02;
            ViewBag.Sequence_03 = seq.Sequence_03;
            ViewBag.Sequence_04 = seq.Sequence_04;
            ViewBag.Sequence_05 = seq.Sequence_05;
            return View(seq);
        }
    }
}