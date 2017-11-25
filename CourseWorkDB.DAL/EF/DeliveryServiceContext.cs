using System;
using System.Data.Entity;
using CourseWorkDB.DAL.Entities;

namespace CourseWorkDB.DAL.EF
{
    public class DeliveryServiceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishCategory> DishCategory { get; set; }

        public DeliveryServiceContext() : base("DeliveryService")
        {
            Database.SetInitializer<DeliveryServiceContext>(new DeliveryServiceDbInitializer());
        }

        public class DeliveryServiceDbInitializer : DropCreateDatabaseIfModelChanges<DeliveryServiceContext>
        {
            protected override void Seed(DeliveryServiceContext db)
            {
                db.Users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    DiscountInPercent = 6,
                    Email = "dfkkfjg#flgkfkjgk@dv.com",
                    Name = "Jack",
                    Password = "454646",
                    Patronymic = "gfgfgf",
                    PhoneNumber = "249584954985945",
                    Surname = "fgfhfh",
                    TotalSpentMoney = 346
                });
                db.SaveChanges();
            }
        }
    }
}