using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkDB.DAL.EF;
using CourseWorkDB.DAL.Entities;
using CourseWorkDB.DAL.Interfaces;

namespace CourseWorkDB.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly DeliveryServiceContext _db;

        public UserRepository(DeliveryServiceContext context)
        {
            _db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User Get(int id)
        {
            return _db.Users.Find(id);
        }

        public void Create(User book)
        {
            _db.Users.Add(book);
        }

        public void Update(User book)
        {
            _db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return _db.Users.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            var book = _db.Users.Find(id);
            if (book != null)
                _db.Users.Remove(book);
        }


    }
}
