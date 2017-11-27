using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWorkDB.Models
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

        public virtual IList<DishCategory> DishCategories { get; set; }
        public virtual IList<Dish> Dishes { get; set; }
    }
}
