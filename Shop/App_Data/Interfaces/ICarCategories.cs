using Shop.App_Data.Models;

namespace Shop.App_Data.Interfaces {
    public interface ICarCategories {

        IEnumerable<Category> AllCategories { get; }

    }
}
