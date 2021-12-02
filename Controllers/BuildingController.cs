using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Code.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildingController : ControllerBase
    {


        private readonly ILogger<BuildingController> _logger;

        public BuildingController(ILogger<BuildingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Building> Get()
        {

            var buildings = new List<Building>();

            buildings.Add(new Building
            {
                Id = 1,
                Name = "The Shard",
                Street = "London Bridge St",
                Town = "London",
                Postcode = "SE1 9SG",
                FloorsNumber = 87,
                Country = "United Kingdom"

            });

            buildings.Add(new Building
            {
                Id = 2,
                Name = "One Canada Square",
                Street = "Canary Wharf",
                Town = "London",
                Postcode = "E14 5AB",
                FloorsNumber = 50,
                Country = "United Kingdom"

            });

            buildings.Where(x => x.Country == "United Kingdom");

            return buildings;
        }

        [HttpGet("{id:int}")]
        public Building GetBuildingById(int id)
        {
            var buildings = new List<Building>();

            buildings.Add(new Building
            {
                Id = 1,
                Name = "The Shard",
                Street = "London Bridge St",
                Town = "London",
                Postcode = "SE1 9SG",
                FloorsNumber = 87,
                Country = "United Kingdom"

            }); ;

            buildings.Add(new Building
            {
                Id = 2,
                Name = "One Canada Square",
                Street = "Canary Wharf",
                Town = "London",
                Postcode = "E14 5AB",
                FloorsNumber = 50,
                Country = "United Kingdom"

            });

            Building b = new Building();


            for (int i = 0; i < buildings.Count; i++)
            {
                if (buildings[i].Id == id)
                {
                    b = buildings[i];
                }
            }

            return b;

        }

        [HttpPost("create")]
        public async Task<ActionResult<List<Building>>> CreateBuilding(Building b)
        {
            var buildings = new List<Building>();

            buildings.Add(new Building
            {
                Id = 1,
                Name = "The Shard",
                Street = "London Bridge St",
                Town = "London",
                Postcode = "SE1 9SG",
                FloorsNumber = 87,
                Country = "United Kingdom"

            });

            buildings.Add(new Building

            {
                Id = 2,
                Name = "One Canada Square",
                Street = "Canary Wharf",
                Town = "London",
                Postcode = "E14 5AB",
                FloorsNumber = 50,
                Country = "United Kingdom"

            });

            buildings.Add(b);


            return buildings;

        }

        [HttpPut("update")]
        public async Task<ActionResult<List<Building>>> UpdateBuilding(Building b)
        {
            var buildings = new List<Building>();

            buildings.Add(new Building
            {
                Id = 1,
                Name = "The Shard",
                Street = "London Bridge St",
                Town = "London",
                Postcode = "SE1 9SG",
                FloorsNumber = 87,
                Country = "United Kingdom"

            });

            buildings.Add(new Building

            {
                Id = 2,
                Name = "One Canada Square",
                Street = "Canary Wharf",
                Town = "London",
                Postcode = "E14 5AB",
                FloorsNumber = 50,
                Country = "United Kingdom"

            });

            for (int i = 0; i < buildings.Count; i++)
            {
                if (buildings[i].Id == b.Id)
                {
                    buildings[i] = b;
                }
            }


            return buildings;

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Building>>> DeleteBuildingById(int id)
        {
            var buildings = new List<Building>();

            buildings.Add(new Building
            {
                Id = 1,
                Name = "The Shard",
                Street = "London Bridge St",
                Town = "London",
                Postcode = "SE1 9SG",
                FloorsNumber = 87,
                Country = "United Kingdom"

            }); ;

            buildings.Add(new Building
            {
                Id = 2,
                Name = "One Canada Square",
                Street = "Canary Wharf",
                Town = "London",
                Postcode = "E14 5AB",
                FloorsNumber = 50,
                Country = "United Kingdom"

            });


            for (int i = 0; i < buildings.Count; i++)
            {
                if (buildings[i].Id == id)
                {
                    buildings.Remove(buildings[i]);
                }
            }

            return buildings;

        }
    }
}
