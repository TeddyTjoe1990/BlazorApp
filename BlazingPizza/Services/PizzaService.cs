using BlazingPizza.Models;
using System.Collections.Generic;

namespace BlazingPizza.Services
{
    public class PizzaService
    {
        public List<Pizza> GetSpecials()
        {
            return new List<Pizza>
            {
                new Pizza
                {
                    Id = 1,
                    Name = "Margherita",
                    Description = "Classic delight with cheese and tomatoes.",
                    Price = 8.99m,
                    ImageUrl = "images/margherita.jpg"
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Description = "Loaded with spicy pepperoni.",
                    Price = 10.99m,
                    ImageUrl = "images/pepperoni.jpg"
                }
            };
        }
    }
}
