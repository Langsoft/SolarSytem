using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using LangSoft.SolarSystem.API.Models;
using LangSoft.SolarSystem.API.Repositories;

namespace LangSoft.SolarSystem.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IRepository<Planet, int>, PlanetRepository>;
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}