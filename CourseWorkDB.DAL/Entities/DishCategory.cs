using System.ComponentModel.DataAnnotations;

namespace CourseWorkDB.DAL.Entities
{
    public class DishCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательное поле")]
        [Display(Name = "Название")]
        public string Name { get; set; }
    }
}