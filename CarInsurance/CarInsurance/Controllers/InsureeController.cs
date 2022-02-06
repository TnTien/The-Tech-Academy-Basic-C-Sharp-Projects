using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            //  This was added to make ensure that all data in the Quotes is automatically calculated if it was 0 to start.
            //  With this, a quote can never equal 0
            var update = (from c in db.Insurees where c.Quote == 0.00M select c).ToList();

            foreach (var up in update)
            {
                db.Insurees.Add(Quote(up));
                //  this makes sure that the data is updated and not create a new insuree
                db.Entry(up).State = EntityState.Modified;
                db.SaveChanges();
            }
            // End
               
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                //  When a new insuree gets added, this will calculate the quote and add it to the database
                db.Insurees.Add(Quote(insuree));
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //  When an insuree edits some data, this will calculate the quote based on the new data
                db.Insurees.Add(Quote(insuree));
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        //  This calculates the Insuree's age based on the DOB.
        private int Age(DateTime id)
        {

                DateTime insureeDOB = id;
                DateTime current = DateTime.Now;

                int age = current.Year - insureeDOB.Year;

                if (current.Month < insureeDOB.Month || ((current.Month == insureeDOB.Month) && (current.Day < insureeDOB.Day)))
                {
                    age--;
                }
                return age;

        }
        //  This will calculate the Quote based on the criteria and what the data of the Insuree is
        private Insuree Quote([Bind(Include = "DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
                decimal quote = 50;
                var insureeAge = Age(insuree.DateOfBirth);

                if (insureeAge <= 18)
                {
                    quote += 100;
                }
                else if (insureeAge >= 19 && insureeAge <= 25)
                {
                    quote += 50;
                }
                else
                {
                    quote += 25;
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote += 25;
                }

                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                }

                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                }

                int speedTicket = insuree.SpeedingTickets;

                while (speedTicket > 0)
                {
                    quote += 10;
                    speedTicket -= 1;
                }

                if (insuree.DUI)
                {
                    quote += quote * .25M;
                }

                if (insuree.CoverageType)
                {
                    quote += quote * .50M;
                }
                insuree.Quote = quote;
                return insuree;
        }
    }
}
