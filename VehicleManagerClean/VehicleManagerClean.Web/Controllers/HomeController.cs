using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleManagerClean.Core.Domain;
using VehicleManagerClean.Core.Infrastructure;
using VehicleManagerClean.Core.Repository;

namespace VehicleManagerClean.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork, IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
            _unitOfWork = unitOfWork;
        }

        #region Views
        public ActionResult Index()
        {
            return View(_vehicleRepository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);

            return View(vehicle);
        }

        public ActionResult Delete(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle != null)
            {
                _vehicleRepository.Delete(vehicle);
                _unitOfWork.Commit();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);

            return View(vehicle);
        }
        #endregion

        #region API Endpoints
        public ActionResult CreateVehicle(Vehicle vehicle)
        {
            if(!ModelState.IsValid)
            {
                return Redirect("Error");
            }

            _vehicleRepository.Add(vehicle);
            _unitOfWork.Commit();

            return RedirectToAction("Index");
        }

        public ActionResult UpdateVehicle(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);

            _unitOfWork.Commit();

            return RedirectToAction("Index");
        }
        #endregion
    }
}