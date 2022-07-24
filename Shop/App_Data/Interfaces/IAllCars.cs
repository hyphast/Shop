using Shop.App_Data.Models;

namespace Shop.App_Data.Interfaces {
    public interface IAllCars {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getCar(int id);
    }
}
