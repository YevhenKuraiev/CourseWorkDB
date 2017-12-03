using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class DishCategoriesController : Controller
    {
        private readonly IGenericRepository<DishCategory> _db;

        public DishCategoriesController(IGenericRepository<DishCategory> db)
        {
            _db = db;
        }

        // GET: DishCategories
        public ActionResult Index()
        {
            return View(_db.Get().ToList());
        }

        // GET: DishCategories/Details/5
        public ActionResult Details(int id)
        {
            DishCategory dishCategory = _db.FindById(id);
            if (dishCategory == null)
            {
                return HttpNotFound();
            }
            return View(dishCategory);
        }

        // GET: DishCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DishCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] DishCategory dishCategory)
        {
            if (ModelState.IsValid)
            {
                _db.Create(dishCategory);
                return RedirectToAction("Index");
            }

            return View(dishCategory);
        }

        // GET: DishCategories/Edit/5
        public ActionResult Edit(int id)
        {
            DishCategory dishCategory = _db.FindById(id);
            if (dishCategory == null)
            {
                return HttpNotFound();
            }
            return View(dishCategory);
        }

        // POST: DishCategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] DishCategory dishCategory)
        {
            if (ModelState.IsValid)
            {
                _db.Update(dishCategory);
                return RedirectToAction("Index");
            }
            return View(dishCategory);
        }

        // GET: DishCategories/Delete/5
        public ActionResult Delete(int id)
        {
            DishCategory dishCategory = _db.FindById(id);
            if (dishCategory == null)
            {
                return HttpNotFound();
            }
            return View(dishCategory);
        }

        // POST: DishCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DishCategory dishCategory = _db.FindById(id);
            _db.Remove(dishCategory);
            return RedirectToAction("Index");
        }
    }
}
