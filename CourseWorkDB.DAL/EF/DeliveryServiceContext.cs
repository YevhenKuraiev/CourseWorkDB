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
        public DbSet<DishCategory> DishCategories { get; set; }
        public DbSet<Order> Orders { get; set; }

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

                db.Users.Add(new User
                {
                    Id = 5,
                    Name = "Александра",
                    Surname = "Яковлева",
                    Patronymic = "Олеговна",
                    Password = "Umyz9zp6keBx",
                    Email = "kozutonume@p33.org",
                    PhoneNumber = "8 (929) 382-79-24",
                    DiscountInPercent = 2,
                    TotalSpentMoney = (decimal)15908.458
                });

                db.Users.Add(new User
                {
                    Id = 6,
                    Name = "Ядвига",
                    Surname = "Арджеванидзе",
                    Patronymic = "Степановна",
                    Password = "jj0olEPMB9sU",
                    Email = "9tqgm@wimsg.com",
                    PhoneNumber = "8 (930) 236-39-94",
                    DiscountInPercent = 25,
                    TotalSpentMoney = (decimal)55908.458
                });

                db.Users.Add(new User
                {
                    Id = 7,
                    Name = "Алла",
                    Surname = "Шашкова",
                    Patronymic = "Ивановна",
                    Password = "D56OS8WwHnIq",
                    Email = "rucatozoda@cobin2hood.com",
                    PhoneNumber = "8 (966) 790-71-13",
                    DiscountInPercent = 55,
                    TotalSpentMoney = (decimal)155908.458
                });

                db.Users.Add(new User
                {
                    Id = 8,
                    Name = "Беатриса",
                    Surname = "Литвина",
                    Patronymic = "Ивановна",
                    Password = "b1quXh7uBYB8",
                    Email = "10a74162@emailo.pro",
                    PhoneNumber = "8 (946) 351-71-96",
                    DiscountInPercent = 65,
                    TotalSpentMoney = (decimal)345908.458
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

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 4,
                    Name = "Шарикофф",
                    Adrress = "ул. Квитки-Основьяненко,12, Харьков 61003, Украина",
                    Rating = "5"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 5,
                    Name = "Старгород",
                    Adrress = "ул. Лермонтовская, 7, Харьков 61024, Украина",
                    Rating = "4"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 6,
                    Name = "44 Favorite Place",
                    Adrress = "Пушкинская 44, Харьков, Украина",
                    Rating = "3"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 7,
                    Name = "Loza Strekoza",
                    Adrress = "Пер. Театральный, 11/13, Харьков, Украина",
                    Rating = "2"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 8,
                    Name = "Brilliant Bar",
                    Adrress = "пр. Независимости, 10А, Харьков, Украина",
                    Rating = "5"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 9,
                    Name = "Red Door Pub",
                    Adrress = "ул. Гоголя, 2A, Харьков, Украина",
                    Rating = "5"
                });

                db.Restaurants.Add(new Restaurant()
                {
                    Id = 10,
                    Name = "Ресторан Чехов",
                    Adrress = "Ул. Сумская, 84/2, Харьков 61002, Украина",
                    Rating = "4"
                });

                #endregion

                #region Dishes
                db.Dishes.Add(new Dish()
                {
                    Id = 0,
                    Name = "Пицца с моцарелой",
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

                db.Dishes.Add(new Dish()
                {
                    Id = 5,
                    Name = "Котлета куриная",
                    CookingTime = "15 минут",
                    Price = 20
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 6,
                    Name = "Котлета по-домашнему",
                    CookingTime = "18 минут",
                    Price = 25
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 7,
                    Name = "Котлета по-киевски",
                    CookingTime = "28 минут",
                    Price = 43
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 8,
                    Name = "Шопский салат",
                    CookingTime = "36 минут",
                    Price = 79
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 9,
                    Name = "Ризотто",
                    CookingTime = "23 минуты",
                    Price = 123
                });

                db.Dishes.Add(new Dish()
                {
                    Id = 10,
                    Name = "Картошка по-криольски",
                    CookingTime = "31 минуту",
                    Price = 99
                });
                #endregion

                #region DishCategories
                db.DishCategories.Add(new DishCategory()
                {
                    Id = 0,
                    Name = "Пиццы"
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

                db.DishCategories.Add(new DishCategory()
                {
                    Id = 5,
                    Name = "Котлеты"
                });

                db.DishCategories.Add(new DishCategory()
                {
                    Id = 6,
                    Name = "Салаты"
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

                db.Orders.Add(new Order()
                {
                    Id = 3,
                    DateTime = DateTime.Now,
                    NumberOfSpentBonuses = 2340,
                    Summ = 434,
                    Total = 7844,
                });

                db.Orders.Add(new Order()
                {
                    Id = 4,
                    DateTime = DateTime.Now,
                    NumberOfSpentBonuses = 5640,
                    Summ = 5445,
                    Total = 12345,
                });

                db.Orders.Add(new Order()
                {
                    Id = 5,
                    DateTime = DateTime.Now,
                    NumberOfSpentBonuses = 35467,
                    Summ = 324546,
                    Total = 1268345,
                });


                #endregion
                db.SaveChanges();
            }
        }

        
    }
}