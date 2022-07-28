using Shop.App_Data.Interfaces;
using Shop.App_Data.Models;

namespace Shop.App_Data.mocks {
    public class MockCars : ICars {

        private readonly ICarCategories _carCategories = new MockCarCategories();

        public IEnumerable<Car> Cars { 
            get {
                return new List<Car> {
                    new Car { 
                        name = "Tesla",
                        shortDesc = "Илон Маск",
                        longDesc = "Эту машину сделал Илон Маск",
                        img = "https://tesla-cdn.thron.com/delivery/public/image/tesla/195458a0-ff67-488c-b972-14d23d2c42fb/bvlatuR/std/1200x630/ms-homepage-social",
                        price = 15000,
                        isFavorite = true,
                        available = true,
                        Category = _carCategories.AllCategories.First()
                    },
                        new Car {
                        name = "BMW",
                        shortDesc = "Германия",
                        longDesc = "Эту машину сделали в Германии",
                        img = "https://www.topgear.com/sites/default/files/2022/06/1-BMW-3-Series.jpg",
                        price = 11000,
                        isFavorite = true,
                        available = false,
                        Category = _carCategories.AllCategories.Last()
                    },
                        new Car {
                        name = "Lexus",
                        shortDesc = "Хороший автомобиль",
                        longDesc = "Очень мощный двигатель",
                        img = "https://cdn.motor1.com/images/mgl/jllw27/s3/2023-lexus-ux.jpg",
                        price = 16400,
                        isFavorite = false,
                        available = true,
                        Category = _carCategories.AllCategories.Last()
                    },
                };
            } 
        }

        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getCar(int id) {
            throw new NotImplementedException();
        }
    }
}
