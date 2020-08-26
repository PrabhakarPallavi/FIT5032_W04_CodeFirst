using FIT5032_W04_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_W04_CodeFirst.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        public ActionResult Index()
        {
            List<EmployeeDetails> Employeelist;

            using (var context = new EmployeeDetailsContext())
            {
                Employeelist = context.EmployeeDetails.ToList();
            }

            return View(Employeelist);
        }
    }
}