using Langsoft.SolarSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Langsoft.SolarSystem.Controllers
{

    public class PlanetDetailController : Controller
    {
        private string planetApi = ConfigurationManager.AppSettings["PlanetsAPI"];
        private HttpClient httpClient;

        public PlanetDetailController()
        {
            if (string.IsNullOrWhiteSpace(planetApi))
            {
                throw new ArgumentNullException("The Planet API url is has not been supplied.");
            }

            httpClient = new HttpClient { BaseAddress = new Uri(planetApi) };
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult>PlanetDetail(string planetName)
        {

            StringBuilder url = new StringBuilder();
            url.Append(planetApi);
            url.Append("/api/Planets");
            url.Append(string.Format("?planetName={0}",planetName));

            SsPlanetDetails objSsPlanetDetails = new SsPlanetDetails();
            
            HttpResponseMessage response = await httpClient.GetAsync(url.ToString());

            if (response.IsSuccessStatusCode)
            {
                var resDataString = response.Content.ReadAsStringAsync();
                var retPlanet = JsonConvert.DeserializeObject<Planet>(resDataString.Result);

                objSsPlanetDetails.Name = retPlanet.Name;
                objSsPlanetDetails.Mass = string.Format ("{0} {1}",retPlanet.Mass.ToString(), retPlanet.MassUnit);
                objSsPlanetDetails.SolarDistance = string.Format("{0} {1}", retPlanet.SolarDistance.ToString(), retPlanet.SolarDistanceUnit);
                objSsPlanetDetails.Diameter = string.Format("{0} {1}", retPlanet.Diameter.ToString(), retPlanet.DiameterUnit);
                objSsPlanetDetails.NoOfMoons = retPlanet.NoOf_Moons.ToString();
                objSsPlanetDetails.ImageUrl = retPlanet.ImageUrl;
            }

            return View(objSsPlanetDetails);

        }
    }
}