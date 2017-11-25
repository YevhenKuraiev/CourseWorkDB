//using System;
//using System.Collections.Generic;
//using CourseWorkDB.DAL.EF;
//using CourseWorkDB.DAL.Entities;
//using CourseWorkDB.DAL.Interfaces;

//namespace CourseWorkDB.DAL.Repositories
//{
//    public class RestaurantRepository : IGenericRepository<Restaurant>
//    {
//        private readonly DeliveryServiceContext _db;

//        public RestaurantRepository(DeliveryServiceContext context)
//        {
//            _db = context;
//        }

//        public void Create(Restaurant item)
//        {
//            throw new NotImplementedException();
//        }

//        public Restaurant FindById(Guid id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Restaurant> Get()
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Restaurant> Get(Func<Restaurant, bool> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public void Remove(Restaurant item)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Restaurant item)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
