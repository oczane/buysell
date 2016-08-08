using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using MyJourney.Models;

namespace MyJourney
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<MyJourney.Services.VisitorLog.IVLog, MyJourney.Services.VisitorLog.VLog>();
            container.RegisterType<MyJourney.Services.CategoryService.ICategoryService, MyJourney.Services.CategoryService.CategoryService>();
            container.RegisterType<MyJourney.Services.AdvertisementService.IAdvertisementService, MyJourney.Services.AdvertisementService.AdvertisementService>();
            container.RegisterType<MyJourney.AppRepository.IRepository<Advertisement>, MyJourney.AppRepository.Repository<Advertisement>>();
            container.RegisterType<MyJourney.AppRepository.IRepository<VisitorLog>, MyJourney.AppRepository.Repository<VisitorLog>>();
            container.RegisterType<MyJourney.AppRepository.IRepository<Category>, MyJourney.AppRepository.Repository<Category>>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}