using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkDB.DAL.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательное поле")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Адрес обязательное поле")]
        [Display(Name = "Адрес")]
        public string Adrress { get; set; }

        [Required(ErrorMessage = "Рейтинг обязательное поле")]
        [Display(Name = "Рейтинг")]
        [Range(1, 5, ErrorMessage = "Рейтинг не может быть меньше 1 и больше 5")]
        public string Rating { get; set; }

        public int IdDishCategory { get; set; }

        [ForeignKey("IdDishCategory")]
        public IEnumerable<DishCategory> DishCategories { get; set; }

        public int IdDish { get; set; }

        [ForeignKey("IdDish")]
        public IEnumerable<Dish> Dishes { get; set; }
    }
}
