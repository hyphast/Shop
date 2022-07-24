using Shop.App_Data.Interfaces;
using Shop.App_Data.Models;

namespace Shop.App_Data.mocks {
    public class MockCategory : ICarCategories {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { name = "Электромобили", description = "Автомобили на электричестве" },
                    new Category { name = "Классические автомобили", description = "Автомобили, к которым мы привыкли" },
                };
            }
        }
    }
}
