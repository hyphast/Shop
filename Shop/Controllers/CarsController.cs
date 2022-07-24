using Microsoft.AspNetCore.Mvc;
using Shop.App_Data.Interfaces;

namespace Shop.Controllers {
    public class CarsController : Controller {

        private readonly ICars _cars;
        private readonly ICarCategories _carCategories;

        public CarsController(ICars cars, ICarCategories carCategories) {
            _cars = cars;
            _carCategories = carCategories;
        }

        public ViewResult List() {
            var cars = _cars.Cars;
            return View(cars);
        }
    }
}
