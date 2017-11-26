using System;
using System.Collections.Generic;

namespace CourseWorkDB.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adrress { get; set; }
        public string Rating { get; set; }

        public virtual IList<DishCategory> DishCategories { get; set; }
        public virtual IList<Dish> Dishes { get; set; }
    }
}
