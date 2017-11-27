using System.ComponentModel.DataAnnotations;

namespace CourseWorkDB.Models
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
        public DishCategory DishCategory { get; set; }

    }
}