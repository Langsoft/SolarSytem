using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LangSoft.SolarSystem.API.Controllers;
using LangSoft.SolarSystem.API.Models;

namespace LangSoft.SolarSystem.API.Tests
{
    [TestClass]
    public class TestPlanetsController
    {
        [TestMethod]
        public void GetAllPlanets_ShouldReturnAllPlanets()
        {
            var testPlanets = GetTestPlanets();
            var controller = new PlanetsController();

            var result = controller.GetPlanets() as List<Planet>;
            Assert.AreEqual(testPlanets.Count, result.Count);
        }

        //[TestMethod]
        //public async Task GetAllPlanetsAsync_ShouldReturnAllPlanets()
        //{
        //    var testPlanets = GetTestPlanets();
        //    var controller = new PlanetsController(testPlanets);

        //    var result = await controller.GetAllPlanetsAsync() as List<Planet>;
        //    Assert.AreEqual(testPlanets.Count, result.Count);
        //}

        //[TestMethod]
        //public void GetPlanet_ShouldReturnCorrectPlanet()
        //{
        //    var testPlanets = GetTestPlanets();
        //    var controller = new SimplePlanetController(testPlanets);

        //    var result = controller.GetPlanet(4) as OkNegotiatedContentResult<Planet>;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testPlanets[3].Name, result.Content.Name);
        //}

        //[TestMethod]
        //public async Task GetPlanetAsync_ShouldReturnCorrectPlanet()
        //{
        //    var testPlanets = GetTestPlanets();
        //    var controller = new SimplePlanetController(testPlanets);

        //    var result = await controller.GetPlanetAsync(4) as OkNegotiatedContentResult<Planet>;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testPlanets[3].Name, result.Content.Name);
        //}

        //[TestMethod]
        //public void GetPlanet_ShouldNotFindPlanet()
        //{
        //    var controller = new SimplePlanetController(GetTestPlanets());

        //    var result = controller.GetPlanet(999);
        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        private List<Planet> GetTestPlanets()
        {
            var testPlanets = new List<Planet>();
            testPlanets.Add(new Planet { Id = 1, Name = "Planet1" });
            //testPlanets.Add(new Planet { Id = 2, Name = "Planet2" });
            //testPlanets.Add(new Planet { Id = 3, Name = "Planet3" });
            //testPlanets.Add(new Planet { Id = 4, Name = "Planet4" });

            return testPlanets;
        }
    }
}