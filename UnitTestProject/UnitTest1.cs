using CourseWorkDB.DAL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWorkDB.DAL.Interfaces;
using Moq;
using CourseWorkDB.Controllers;
using System.Web.Mvc;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatePostAction_RedirectToIndexView()
        {
            // arrange
            object expected = "Index";
            var mock = new Mock<IGenericRepository<Dish>>();
            var controller = new DishesController(mock.Object);
            // act
            RedirectToRouteResult result = controller.Create(new Dish()) as RedirectToRouteResult;

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void EditPostAction_RedirectToIndexView()
        {
            // arrange
            object expected = "Index";
            var mock = new Mock<IGenericRepository<Dish>>();
            var controller = new DishesController(mock.Object);
            // act
            RedirectToRouteResult result = controller.Edit(new Dish()) as RedirectToRouteResult;

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void CreatePostAction_SaveModel()
        {
            // arrange
            var mock = new Mock<IGenericRepository<Dish>>();
            var dish = new Dish();
            var controller = new DishesController(mock.Object);
            // act
            RedirectToRouteResult result = controller.Create(dish) as RedirectToRouteResult;
            // assert
            mock.Verify(a => a.Create(dish));
        }

        [TestMethod]
        public void EditPostAction_EditModel()
        {
            // arrange
            var mock = new Mock<IGenericRepository<Dish>>();
            var dish = new Dish();
            var controller = new DishesController(mock.Object);
            // act
            RedirectToRouteResult result = controller.Edit(dish) as RedirectToRouteResult;
            // assert
            mock.Verify(a => a.Update(dish));
        }

    }
}
