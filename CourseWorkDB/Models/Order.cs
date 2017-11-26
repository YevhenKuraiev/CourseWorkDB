using System;
using System.Collections.Generic;

namespace CourseWorkDB.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Summ { get; set; }
        public int NumberOfSpentBonuses { get; set; }
        public decimal Total { get; set; }
        public User User { get; set; }
        public virtual IList<Dish> Dishes { get; set; }
    }
}