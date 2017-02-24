using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleManager.Web.Infrastructure;
using VehicleManager.Web.Models;

namespace VehicleManager.Web.Controllers
{
    public class VehicleController : Controller
    {
        private VehicleManagerDataContext db = new VehicleManagerDataContext();
        // GET: Vehicle
        public ActionResult Index()
        {
            return View(db.Vehicles.ToArray());
        }

        public ActionResult Delete(int id)
        {
            if(db.Vehicles.Find(id) != null)
            {
                db.Vehicles.Remove(db.Vehicles.Find(id));
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Vehicle");
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        public ActionResult Edit(int id)
        {
            var vehicle = db.Vehicles.Find(id);
            return View(vehicle);
        }

        public ActionResult CreateVehicle(Vehicle vehicle)
        {
            if(!ModelState.IsValid)
            {
                return Redirect("Error");
            }

            db.Vehicles.Add(vehicle);
            db.SaveChanges();

            return RedirectToAction("Details", "Vehicle", new { id = vehicle.VehicleId });
        }

        public ActionResult UpdateVehicle(Vehicle vehicle)
        {
            var dbVehicle = db.Vehicles.Find(vehicle.VehicleId);

            db.Entry(dbVehicle).CurrentValues.SetValues(vehicle);

            db.SaveChanges();

            return RedirectToAction("Index", "Vehicle");
        }
    }
}