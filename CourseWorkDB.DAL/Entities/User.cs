using System;

namespace CourseWorkDB.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte DiscountInPercent { get; set; }
        public decimal TotalSpentMoney { get; set; }

        public User()
        {
                
        }
    }


}