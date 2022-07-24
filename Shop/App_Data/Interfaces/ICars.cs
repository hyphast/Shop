using Shop.App_Data.Models;

namespace Shop.App_Data.Interfaces {
    public interface ICars {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getCar(int id);
    }
}
