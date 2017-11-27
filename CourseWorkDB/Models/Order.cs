using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWorkDB.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Дата обязательное поле")]
        [Display(Name = "Дата")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Общая сумма обязательное поле")]
        [Display(Name = "Общая сумма")]
        [Range(1, 100000000, ErrorMessage = "Общая сумма не может быть отрицательной")]
        public decimal Summ { get; set; }

        [Display(Name = "Количество потраченных бонусов")]
        [Range(1, 100000000, ErrorMessage = "Сумма не может быть отрицательной")]
        public int NumberOfSpentBonuses { get; set; }

        [Required(ErrorMessage = "Итоговая сумма обязательное поле")]
        [Display(Name = "Итоговая сумма")]
        [Range(1, 100000000, ErrorMessage = "Итоговая сумма не может быть отрицательной")]
        public decimal Total { get; set; }
        public User User { get; set; }
        public virtual IList<Dish> Dishes { get; set; }
    }
}