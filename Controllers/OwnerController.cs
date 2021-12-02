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
    public class OwnerController : Controller
    {
       

        [HttpGet]
        public IEnumerable<Owner> GetOwners()
        {
            var owners = new List<Owner>();

            owners.Add(new Owner {
                Id = 1,
                Nome = "Alberto Caeiro",
                Idade = 31,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 2,
                Nome = "José Coimbra",
                Idade = 40,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 3,
                Nome = "Carla Rocha",
                Idade = 43,
                flat = new Flat()
            });

            return owners;
        }

        [HttpGet("{id:int}")]
        public Owner GetOwnerBydId(int id)
        {
            var owners = new List<Owner>();

            owners.Add(new Owner
            {
                Id = 1,
                Nome = "Alberto Caeiro",
                Idade = 31,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 2,
                Nome = "José Coimbra",
                Idade = 40,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 3,
                Nome = "Carla Rocha",
                Idade = 43,
                flat = new Flat()
            });

            Owner o = new Owner();

            for (int i = 0; i < owners.Count; i++)
            {
                if (id == owners[i].Id)
                {
                    o = owners[i];
                }
            }

            return o;
        }

        [HttpPost]
        public async Task<ActionResult<List<Owner>>> CreateOwner(Owner owner)
        {
            var owners = new List<Owner>();

            owners.Add(new Owner
            {
                Id = 1,
                Nome = "Alberto Caeiro",
                Idade = 31,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 2,
                Nome = "José Coimbra",
                Idade = 40,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 3,
                Nome = "Carla Rocha",
                Idade = 43,
                flat = new Flat()
            });

            owners.Add(owner);

            return owners;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<List<Owner>>> UpdateOwner(Owner owner)
        {
            var owners = new List<Owner>();

            owners.Add(new Owner
            {
                Id = 1,
                Nome = "Alberto Caeiro",
                Idade = 31,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 2,
                Nome = "José Coimbra",
                Idade = 40,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 3,
                Nome = "Carla Rocha",
                Idade = 43,
                flat = new Flat()
            });

            for (int i = 0; i < owners.Count; i++)
            {
                if (owners[i].Id == owner.Id)
                {
                    owners[i] = owner;
                }
            }

            return owners;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<List<Owner>>> DeleteOwner(int id)
        {
            var owners = new List<Owner>();

            owners.Add(new Owner
            {
                Id = 1,
                Nome = "Alberto Caeiro",
                Idade = 31,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 2,
                Nome = "Jose Coimbra",
                Idade = 40,
                flat = new Flat()
            });

            owners.Add(new Owner
            {
                Id = 3,
                Nome = "Carla Rocha",
                Idade = 43,
                flat = new Flat()
            });


            for (int i = 0; i < owners.Count; i++)
            {
                if (owners[i].Id == id)
                {
                    owners.Remove(owners[i]);
                    return Ok(owners);
                }

            }

            return NotFound();

            
        }

    }
}
