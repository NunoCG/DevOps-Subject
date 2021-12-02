using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Model;

namespace Code.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlatController : Controller
    {
        

        [HttpGet]
        public IEnumerable<Flat> Get()
        {

            var flats = new List<Flat>();

            flats.Add(new Flat
            {
                id = 1,
                floorsNumber = 3,
                floor = "esquerdo",
                street = "Rua Sardinha 37",
                postcode = "3680-044",
                size = 87,
                owner = new Owner()
            });

            flats.Add(new Flat
            {
                id = 2,
                floorsNumber = 2,
                floor = "direito",
                street = "Quinta Beloura 107",
                postcode = "2715-359",
                size = 104,
                owner = new Owner()
            });

            return flats;
        }

        [HttpGet("{id:int}")]
        public Flat GetFlatById(int id)
        {

            var flats = new List<Flat>();

            flats.Add(new Flat
            {
                id = 1,
                floorsNumber = 3,
                floor = "esquerdo",
                street = "Rua Sardinha 37",
                postcode = "3680-044",
                size = 87,
                owner = new Owner()
            });

            flats.Add(new Flat
            {
                id = 2,
                floorsNumber = 2,
                floor = "direito",
                street = "Quinta Beloura 107",
                postcode = "2715-359",
                size = 104,
                owner = new Owner()
            });

            Flat f = new Flat();


            for (int i = 0; i < flats.Count; i++)
            {
                if (flats[i].id == id)
                {
                    f = flats[i];
                }
            }
            return f;
        }

        [HttpPost("create")]
        public async Task<ActionResult<List<Flat>>> CreateFlat(Flat f)
        {
            var flats = new List<Flat>();

            flats.Add(new Flat
            {
                id = 1,
                floorsNumber = 3,
                floor = "esquerdo",
                street = "Rua Sardinha 37",
                postcode = "3680-044",
                size = 87,
                owner = new Owner()
            });

            flats.Add(new Flat
            {
                id = 2,
                floorsNumber = 2,
                floor = "direito",
                street = "Quinta Beloura 107",
                postcode = "2715-359",
                size = 104,
                owner = new Owner()
            });

            flats.Add(f);

            return flats;
        }

        [HttpPut("update")]
        public async Task<ActionResult<List<Flat>>> UpdateFlat(Flat f)
        {
            var flats = new List<Flat>();

            flats.Add(new Flat
            {
                id = 1,
                floorsNumber = 3,
                floor = "esquerdo",
                street = "Rua Sardinha 37",
                postcode = "3680-044",
                size = 87,
                owner = new Owner()
            });

            flats.Add(new Flat
            {
                id = 2,
                floorsNumber = 2,
                floor = "direito",
                street = "Quinta Beloura 107",
                postcode = "2715-359",
                size = 104,
                owner = new Owner()
            });

            for (int i = 0; i < flats.Count; i++)
            {
                if (flats[i].id == f.id)
                {
                    flats[i] = f;
                }
            }
            return flats;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Flat>>> DeleteFlatById(int id)
        {
            var flats = new List<Flat>();

            flats.Add(new Flat
            {
                id = 1,
                floorsNumber = 3,
                floor = "esquerdo",
                street = "Rua Sardinha 37",
                postcode = "3680-044",
                size = 87,
                owner = new Owner()
            });

            flats.Add(new Flat
            {
                id = 2,
                floorsNumber = 2,
                floor = "direito",
                street = "Quinta Beloura 107",
                postcode = "2715-359",
                size = 104,
                owner = new Owner()
            });


            for (int i = 0; i < flats.Count; i++)
            {
                if (flats[i].id == id)
                {
                    flats.Remove(flats[i]);
                }
            }
            return flats;
        }













    }
}
