using DependencyInjection.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DependencyInjection
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IUserMasterRepository, UserMasterRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}