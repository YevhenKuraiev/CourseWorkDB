﻿using System.Data.Entity;

namespace CourseWorkDB.Models
{
    public class DeliveryServiceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishCategory> DishCategories { get; set; }

        public DeliveryServiceContext() : base("DeliveryService")
        {
            //Database.SetInitializer<DeliveryServiceContext>(new DeliveryServiceDbInitializer());
        }

        public class DeliveryServiceDbInitializer : DropCreateDatabaseIfModelChanges<DeliveryServiceContext>
        {
            protected override void Seed(DeliveryServiceContext db)
            {
                db.Users.Add(new User
                {
                    Id = 0,
                    DiscountInPercent = 6,
                    Email = "top.down@user.com",
                    Name = "Владик",
                    Password = "454646",
                    Patronymic = "Юрьевич",
                    PhoneNumber = "+380508475904",
                    Surname = "Юрьевич",
                    TotalSpentMoney = 346
                });

                db.Users.Add(new User
                {
                    Id = 1,
                    DiscountInPercent = 6,
                    Email = "top.down@user.com",
                    Name = "Jack",
                    Password = "454646",
                    Patronymic = "Юрьевич",
                    PhoneNumber = "+380508475904",
                    Surname = "Юрьевич",
                    TotalSpentMoney = 346
                });
                db.SaveChanges();
            }
        }

        public System.Data.Entity.DbSet<CourseWorkDB.Models.Order> Orders { get; set; }
    }
}