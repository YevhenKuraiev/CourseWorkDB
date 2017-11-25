using System;
using CourseWorkDB.DAL.Entities;

namespace CourseWorkDB.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Phones { get; }
        IRepository<Restaurant> Orders { get; }
        void Save();
    }
}
