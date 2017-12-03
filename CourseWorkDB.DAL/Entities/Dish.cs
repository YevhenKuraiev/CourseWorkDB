using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkDB.DAL.Entities
{
    public class Dish
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательное поле")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Время приготовления обязательное поле")]
        [Display(Name = "Время приготовления")]
        public string CookingTime { get; set; }

        [Required(ErrorMessage = "Цена обязательное поле")]
        [Display(Name = "Цена")]
        [Range(1, 100000000, ErrorMessage = "Цена не может быть отрицательной")]
        public decimal Price { get; set; }
        [Display(Name = "Номер категории")]
        public int IdDishCategory { get; set; }

        [ForeignKey("IdDishCategory")]
        public IEnumerable<DishCategory> DishCategory { get; set; }


    }
}