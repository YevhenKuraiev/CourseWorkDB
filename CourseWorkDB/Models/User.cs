using System.ComponentModel.DataAnnotations;

namespace CourseWorkDB.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательное поле")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Фамилия обязательное поле")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Отчество обязательное поле")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Номер телефона обязательное поле")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Пароль обязательное поле")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email обязательное поле")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Скидка обязательное поле")]
        [Display(Name = "Скидка в %")]
        [Range(typeof(byte), "0", "100", ErrorMessage = "От 0 до 100%")]
        public byte DiscountInPercent { get; set; }

        [Required(ErrorMessage = "Сумма потраченных денег обязательное поле")]
        [Display(Name = "Сумма потраченных денег")]
        [Range (0, 100000000000, ErrorMessage = "Сумма не должна быть отрицательной")]
        public decimal TotalSpentMoney { get; set; }

        public User()
        {
                
        }
    }


}