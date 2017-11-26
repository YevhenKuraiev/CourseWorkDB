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
                    Email = "dfkkfjg#flgkfkjgk@dv.com",
                    Name = "Jack",
                    Password = "454646",
                    Patronymic = "gfgfgf",
                    PhoneNumber = "249584954985945",
                    Surname = "fgfhfh",
                    TotalSpentMoney = 346
                });
                db.Dishes.Add(new Dish());
                //db.DishCategory.Add(new DishCategory());
                db.Restaurants.Add(new Restaurant());
                db.Users.Add(new User
                {
                    Id = 0,
                    DiscountInPercent = 6,
                    Email = "dfkkfjg#flgkfkjgk@dv.com",
                    Name = "Jack",
                    Password = "454646",
                    Patronymic = "gfgfgf",
                    PhoneNumber = "249584954985945",
                    Surname = "fgfhfh",
                    TotalSpentMoney = 346
                });
                db.Dishes.Add(new Dish());
                //db.DishCategory.Add(new DishCategory());
                db.Restaurants.Add(new Restaurant());
                db.SaveChanges();
            }
        }

        public System.Data.Entity.DbSet<CourseWorkDB.Models.Order> Orders { get; set; }
    }
}