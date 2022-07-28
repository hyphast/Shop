using Shop.App_Data.Models;

namespace Shop.View_Models {
    public class CarsListViewModel {

        public IEnumerable<Car> allCars { get; set; }

        public string curCategory { get; set; }
    }
}
