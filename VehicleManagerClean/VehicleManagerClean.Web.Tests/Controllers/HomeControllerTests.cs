using Moq;
using NUnit.Framework;
using System.Web.Mvc;
using VehicleManagerClean.Core.Domain;
using VehicleManagerClean.Core.Infrastructure;
using VehicleManagerClean.Core.Repository;
using VehicleManagerClean.Web.Controllers;

namespace VehicleManagerClean.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        HomeController sut;

        [OneTimeSetUp]
        public void TestSetup()
        {
            var mockVehicleRepository = new Mock<IVehicleRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            sut = new HomeController(mockVehicleRepository.Object, mockUnitOfWork.Object);
        }

        [Test]
        public void ShouldCreateVehicle()
        {
            var response = sut.CreateVehicle(new Vehicle());

            Assert.That(response, Is.TypeOf<RedirectToRouteResult>());
        }
    }
}
