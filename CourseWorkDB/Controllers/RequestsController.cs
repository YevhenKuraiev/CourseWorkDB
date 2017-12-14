using System;
using System.Linq;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Restaurant> _restaurantsRepository;
        private readonly IGenericRepository<Order> _ordersRepository;
        private readonly IGenericRepository<Dish> _dishesRepository;
        public RequestsController(IGenericRepository<User> userRepository, 
            IGenericRepository<Restaurant> restaurantsRepository,
            IGenericRepository<Order> ordersRepository,
            IGenericRepository<Dish> dishesRepository)
        {
            _userRepository = userRepository;
            _restaurantsRepository = restaurantsRepository;
            _ordersRepository = ordersRepository;
            _dishesRepository = dishesRepository;
        }
        // GET: Requests
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUsersBySpentMoney()
        {
            var listOfUsers = _userRepository.Get().Where(x => x.TotalSpentMoney > 1000).ToList();
            return View(listOfUsers);
        }

        public ActionResult GetRestarauntsByRaiting()
        {
            var listOfRestaraunts = _restaurantsRepository.Get().Where(x => Convert.ToInt32(x.Rating) > 3).ToList();
            return View(listOfRestaraunts);
        }

        public ActionResult GetOrdersBySumm()
        {
            var listOfOrders = _ordersRepository.Get().Where(x => x.Summ > 500).ToList();
            return View(listOfOrders);
        }

        public ActionResult GetDishesByTimeCooking()
        {
            var listOfDishes = _dishesRepository.Get().Where(
                x => Convert.ToInt32(x.CookingTime.Substring(0, 2)) < 30).ToList();
            return View(listOfDishes);
        }

        public ActionResult GetUsersByDiscountPercent()
        {
            var listOfUsers = _userRepository.Get().Where(
                x => x.DiscountInPercent > 25 && x.DiscountInPercent < 60).ToList();
            return View(listOfUsers);
        }
    }
}