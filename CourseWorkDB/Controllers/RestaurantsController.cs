using System.Linq;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IGenericRepository<Restaurant> _db;

        public RestaurantsController(IGenericRepository<Restaurant> db)
        {
            _db = db;
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
            ViewData["dishCategories"] = new SelectList(_db.GetWithInclude(x => x.DishCategories), "Id", "Name");
            ViewData["dishes"] = new SelectList(_db.GetWithInclude(x => x.Dishes), "Id", "Name");
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
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
            ViewData["dishCategories"] = new SelectList(_db.GetWithInclude(x => x.DishCategories), "Id", "Name");
            ViewData["dishes"] = new SelectList(_db.GetWithInclude(x => x.Dishes), "Id", "Name");
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
