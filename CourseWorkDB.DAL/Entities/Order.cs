using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkDB.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Дата обязательное поле")]
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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

        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public User User { get; set; }
        //public virtual IList<Dish> Dishes { get; set; }
    }
}