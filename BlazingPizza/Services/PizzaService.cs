using BlazingPizza.Models;

namespace BlazingPizza.Services
{
    public class PizzaService
    {
        public List<Pizza> GetSpecials() => new()
        {
            new Pizza { Id = 1, Name = "Meat Lover", Description = "Full of meats", Price = 80000, ImageUrl = "images/meatlovers.jpg" },
            new Pizza { Id = 2, Name = "Veggie Deluxe", Description = "Healthy and tasty", Price = 70000, ImageUrl = "images/veggie.jpg" }
        };
    }
}
