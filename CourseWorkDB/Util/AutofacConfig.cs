using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using CourseWorkDB.DAL.EF;
using CourseWorkDB.DAL.Interfaces;
using CourseWorkDB.DAL.Repositories;

namespace CourseWorkDB.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // регистрируем споставление типов
            builder.RegisterGeneric(typeof(EFGenericRepository<>)).As(typeof(IGenericRepository<>))
                .WithParameter("context", new DeliveryServiceContext()).InstancePerDependency();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}