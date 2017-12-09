using System.Linq;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IGenericRepository<Order> _db;
        private readonly IGenericRepository<User> _userRepository;

        public OrdersController(IGenericRepository<Order> db, IGenericRepository<User> userRepository)
        {
            _db = db;
            _userRepository = userRepository;
        }

        // GET: Orders
        public ActionResult Index()
        {
            var list = _db.Get().ToList();
            list.ForEach(x => x.User = _userRepository.FindById(x.IdUser));
            return View(list);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            Order order = _db.FindById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewData["users"] = new SelectList(_userRepository.Get(), "Id", "Surname");
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _db.Create(order);
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            Order order = _db.FindById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewData["users"] = new SelectList(_userRepository.Get(), "Id", "Surname");
            return View(order);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                _db.Update(order);
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = _db.FindById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = _db.FindById(id);
            _db.Remove(order);
            return RedirectToAction("Index");
        }
    }
}
