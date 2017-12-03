using System.Linq;
using System.Web.Mvc;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGenericRepository<User> _db;

        public UsersController(IGenericRepository<User> db)
        {
            _db = db;
        }

        // GET: Users
        public ActionResult Index()
        {
            return View(_db.Get().ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            User user = _db.FindById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname,Patronymic,PhoneNumber,Password,Email,DiscountInPercent,TotalSpentMoney")] User user)
        {
            if (ModelState.IsValid)
            {
                _db.Create(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            User user = _db.FindById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname,Patronymic,PhoneNumber,Password,Email,DiscountInPercent,TotalSpentMoney")] User user)
        {
            if (ModelState.IsValid)
            {
                _db.Update(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            User user = _db.FindById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = _db.FindById(id);
            _db.Remove(user);
            return RedirectToAction("Index");
        }
    }
}
