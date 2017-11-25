using CourseWorkDB.DAL.Interfaces;
using System;
using CourseWorkDB.DAL.EF;
using CourseWorkDB.DAL.Entities;

namespace CourseWorkDB.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DeliveryServiceContext _db;
        private UserRepository _phoneRepository;
        private bool _disposed;

        public EFUnitOfWork()
        {
            _db = new DeliveryServiceContext();
        }
        public IRepository<User> Users => _phoneRepository ?? (_phoneRepository = new UserRepository(_db));

        public IRepository<User> Phones => throw new NotImplementedException();

        public IRepository<Restaurant> Orders => throw new NotImplementedException();

        public void Save()
        {
            _db.SaveChanges();
        }

        
        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this._disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
