using System.Linq;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IGenericRepository<Restaurant> _db;
        private readonly IGenericRepository<Dish> _dishRepository;
        private readonly IGenericRepository<DishCategory> _dishCategotyRepo;

        public RestaurantsController(IGenericRepository<Restaurant> db, IGenericRepository<Dish> dishRepository, 
            IGenericRepository<DishCategory> dishCategotyRepo)
        {
            _db = db;
            _dishRepository = dishRepository;
            _dishCategotyRepo = dishCategotyRepo;
        }

        // GET: Restaurants
        public ActionResult Index()
        {
            return View(_db.Get().ToList());
        }

        // GET: Restaurants/Details/5
        public ActionResult Details(int id)
        {
            Restaurant restaurant = _db.FindById(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // GET: Restaurants/Create
        public ActionResult Create()
        {
            ViewData["dishCategories"] = new SelectList(_dishRepository.Get(), "Id", "Name");
            ViewData["dishes"] = new SelectList(_dishCategotyRepo.Get(), "Id", "Name");
            return View();
        }

        // POST: Restaurants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.Create(restaurant);
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public ActionResult Edit(int id)
        {
            Restaurant restaurant = _db.FindById(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            ViewData["dishCategories"] = new SelectList(_dishRepository.Get(), "Id", "Name");
            ViewData["dishes"] = new SelectList(_dishCategotyRepo.Get(), "Id", "Name");
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.Update(restaurant);
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        public ActionResult Delete(int id)
        {
            Restaurant restaurant = _db.FindById(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurant restaurant = _db.FindById(id);
            _db.Remove(restaurant);
            return RedirectToAction("Index");
        }
    }
}
