using System;

namespace CourseWorkDB.DAL.Entities
{
    public class Dish
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CookingTime { get; set; }
        public decimal Price { get; set; }
        public DishCategory DishCategory { get; set; }

    }
}