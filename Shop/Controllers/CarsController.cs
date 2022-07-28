using Microsoft.AspNetCore.Mvc;
using Shop.App_Data.Interfaces;
using Shop.View_Models;

namespace Shop.Controllers {
    public class CarsController : Controller {

        private readonly ICars _cars;
        private readonly ICarCategories _carCategories;

        public CarsController(ICars cars, ICarCategories carCategories) {
            _cars = cars;
            _carCategories = carCategories;
        }

        public ViewResult List() {
            ViewBag.Title = "Все авто";
            CarsListViewModel carsList = new CarsListViewModel();
            carsList.allCars = _cars.Cars;
            carsList.curCategory = "Авто";
            /*var cars = _cars.Cars;*/
            return View(carsList);
        }
    }
}
