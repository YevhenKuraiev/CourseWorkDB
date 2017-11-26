using System;

namespace CourseWorkDB.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CookingTime { get; set; }
        public decimal Price { get; set; }
        public DishCategory DishCategory { get; set; }

    }
}