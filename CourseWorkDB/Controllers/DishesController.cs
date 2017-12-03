using System.Linq;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class DishesController : Controller
    {
        private readonly IGenericRepository<Dish> _db;

        public DishesController(IGenericRepository<Dish> db)
        {
            _db = db;
        }

        // GET: Dishes
        public ActionResult Index()
        {
            return View(_db.Get().ToList());
        }

        // GET: Dishes/Details/5
        public ActionResult Details(int id)
        {
            Dish dish = _db.FindById(id);
            if (dish == null)
            {
                return HttpNotFound();
            }
            return View(dish);
        }

        // GET: Dishes/Create
        public ActionResult Create()
        {
            ViewData["dishCategories"] = new SelectList(_db.GetWithInclude(x => x.DishCategory), "Id", "Name");
            return View();
        }

        // POST: Dishes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dish dish)
        {
            if (ModelState.IsValid)
            {
                _db.Create(dish);
                return RedirectToAction("Index");
            }

            return View(dish);
        }

        // GET: Dishes/Edit/5
        public ActionResult Edit(int id)
        {
            Dish dish = _db.FindById(id);
            if (dish == null)
            {
                return HttpNotFound();
            }
            ViewData["dishCategories"] = new SelectList(_db.GetWithInclude(x => x.DishCategory), "Id", "Name");
            return View(dish);
        }

        // POST: Dishes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dish dish)
        {
            if (ModelState.IsValid)
            {
                _db.Update(dish);
                return RedirectToAction("Index");
            }
            return View(dish);
        }

        // GET: Dishes/Delete/5
        public ActionResult Delete(int id)
        {
            Dish dish = _db.FindById(id);
            if (dish == null)
            {
                return HttpNotFound();
            }
            return View(dish);
        }

        // POST: Dishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dish dish = _db.FindById(id);
            _db.Remove(dish);
            return RedirectToAction("Index");
        }
    }
}
