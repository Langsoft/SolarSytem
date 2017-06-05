using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Langsoft.SolarSystem.Models;
using Newtonsoft.Json;

namespace Langsoft.SolarSystem.Controllers
{
    public class HomeController : Controller
    {
        private string planetApi = ConfigurationManager.AppSettings["PlanetsAPI"];
        private HttpClient httpClient;

        public HomeController()
        {
            if (string.IsNullOrWhiteSpace(planetApi))
            {
                throw new ArgumentNullException("The Planet API url is has not been supplied.");
            }

            httpClient = new HttpClient { BaseAddress = new Uri(planetApi) };
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
        public async Task<ActionResult> Index()
        {
            StringBuilder url = new StringBuilder();
            url.Append(planetApi);
            url.Append("/api/Planets");

            ssPlanetVM objSsPlanetVM = new ssPlanetVM();
            objSsPlanetVM.ssPlanetsObj = new List<SsPlanet>();

            List<Planet> retPlanets = null;
            HttpResponseMessage response = await httpClient.GetAsync(url.ToString());

            if (response.IsSuccessStatusCode)
            {
                var resDataString = response.Content.ReadAsStringAsync();
                retPlanets = JsonConvert.DeserializeObject<List<Planet>>(resDataString.Result);
                foreach (Planet planet in retPlanets)
                {
                    SsPlanet thePlanet = new SsPlanet()
                    {
                        PlanetID = planet.Id,
                        PlanetName = planet.Name
                    };
                    objSsPlanetVM.ssPlanetsObj.Add(thePlanet);
                }
            }

            return View(objSsPlanetVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Planets Application utilising Web-API";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sorry no contact details";

            return View();
        }
    }
}