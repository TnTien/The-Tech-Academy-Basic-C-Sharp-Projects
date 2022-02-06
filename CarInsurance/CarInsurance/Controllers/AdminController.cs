using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;

                var insureesVm = new List<AdminVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new AdminVm();
                    insureeVm.Id = insuree.Id;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.Quote = insuree.Quote;
                    insureesVm.Add(insureeVm);
                }
                return View(insureesVm);
            }
        }
    }
}