﻿using System;
using System.Data.Entity;

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
            Database.SetInitializer<DeliveryServiceContext>(new DeliveryServiceDbInitializer());
        }

        public class DeliveryServiceDbInitializer : DropCreateDatabaseIfModelChanges<DeliveryServiceContext>
        {
            protected override void Seed(DeliveryServiceContext db)
            {
                #region User
                db.Users.Add(new User
                {
                    Id = 0,
                    Name = "Альфред",
                    Surname = "Ерофеев",
                    Patronymic = "Русланович",
                    Password = "123",
                    Email = "bivi@p33.org",
                    PhoneNumber = "8 (964) 514-50-42",
                    DiscountInPercent = 4,
                    TotalSpentMoney = 500
                });

                db.Users.Add(new User
                {
                    Id = 1,
                    Name = "Игорь",
                    Surname = "Голубев",
                    Patronymic = "Валентинович",
                    Password = "SArk7WfLxYHl",
                    Email = "suwutinulu@crymail2.com",
                    PhoneNumber = "8 (956) 454-65-17",
                    DiscountInPercent = 3,
                    TotalSpentMoney = 5000
                });

                db.Users.Add(new User
                {
                    Id = 2,
                    Name = "Климент",
                    Surname = "Дидиченко",
                    Patronymic = "Вячеславович",
                    Password = "9uhuwPaROSbs",
                    Email = "suwutinulu@crymail2.com",
                    PhoneNumber = "8 (925) 392-59-57",
                    DiscountInPercent = 2,
                    TotalSpentMoney = 5500
                });

                db.Users.Add(new User
                {
                    Id = 3,
                    Name = "Любовь",
                    Surname = "Фомова",
                    Patronymic = "Вячеславовна",
                    Password = "gMCRIJUgjkzv",
                    Email = "qbgbprsd@10mail.org",
                    PhoneNumber = "8 (972) 787-46-56",
                    DiscountInPercent = 1,
                    TotalSpentMoney = 15500
                });

                db.Users.Add(new User
                {
                    Id = 4,
                    Name = "Пантелеймон",
                    Surname = "Тайский",
                    Patronymic = "Данилович",
                    Password = "o9h2JUg9WEJT",
                    Email = "etpwmchk@emlpro.com",
                    PhoneNumber = "8 (943) 352-80-15",
                    DiscountInPercent = 3,
                    TotalSpentMoney = (decimal)15508.458
                });
                #endregion

                #region Restaurants

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 0,
                    Name = "МАМА МАНАНА",
                    Adrress = "ул. Большая Васильковская, 44, Киев 01004, Украина",
                    Rating = "4"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 1,
                    Name = "Чачапури",
                    Adrress = "б-р Тараса Шевченко, 36А, Киев 03169, Украина",
                    Rating = "3"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 2,
                    Name = "Спотыкач",
                    Adrress = "ул. Владимирская, 16, Киев 01601, Украина",
                    Rating = "5"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 3,
                    Name = "Одесса",
                    Adrress = "ул. Красноармейская, 114, Киев 03150, Украина",
                    Rating = "3"
                });

                #endregion

                #region Dishes
                db.Dishes.Add(new Dish()
                {
                    Id = 0,
                    Name = "Пицца",
                    CookingTime = "40 минут",
                    Price = 125
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 1,
                    Name = "Пельмени",
                    CookingTime = "20 минут",
                    Price = 90
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 2,
                    Name = "Борщ",
                    CookingTime = "30 минут",
                    Price = 50
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 3,
                    Name = "Грибной суп",
                    CookingTime = "45 минут",
                    Price = 45
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 4,
                    Name = "Отбивная",
                    CookingTime = "15 минут",
                    Price = 20
                });

                #endregion

                #region DishCategories
                db.DishCategories.Add(new DishCategory()
                {
                    Id = 0,
                    Name = "Пицца"
                });

                db.DishCategories.Add(new DishCategory()
                {
                    Id = 1,
                    Name = "Суши"
                });

                db.DishCategories.Add(new DishCategory()
                {
                    Id = 2,
                    Name = "Бургеры"
                });

                db.DishCategories.Add(new DishCategory()
                {
                    Id = 3,
                    Name = "Шашлыки"
                });

                db.DishCategories.Add(new DishCategory()
                {
                    Id = 4,
                    Name = "Пироги"
                });


                #endregion

                #region Orders
                db.Orders.Add(new Order()
                {
                    Id = 0,
                    DateTime = DateTime.Now,
                    NumberOfSpentBonuses = 10,
                    Summ = 234,
                    Total = 444,
                });

                db.Orders.Add(new Order()
                {
                    Id = 1,
                    DateTime = DateTime.Now,
                    NumberOfSpentBonuses = 110,
                    Summ = 2134,
                    Total = 4144,
                });

                db.Orders.Add(new Order()
                {
                    Id = 2,
                    DateTime = DateTime.Now,
                    NumberOfSpentBonuses = 1140,
                    Summ = 21434,
                    Total = 41444,
                });


                #endregion
                db.SaveChanges();
            }
        }

        public System.Data.Entity.DbSet<CourseWorkDB.Models.Order> Orders { get; set; }
    }
}