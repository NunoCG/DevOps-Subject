using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
﻿using Code.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Code.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FloorController : ControllerBase
    {

        private readonly ILogger<FloorController> _logger;
        private readonly object _context;

        public FloorController(ILogger<FloorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Floor> Get()
        {

            var floors = new List<Floor>();
            floors.Add(new Floor
            {
                Id = 1,
                Andar = 2,
                Letra = "A"
            });

            floors.Add(new Floor
            {
                Id = 1,
                Andar = 2,
                Letra = "B"
            });

            return floors;
        }

        [HttpGet("{id:int}")]
        public Floor GetById(int id)
        {
            var floors = new List<Floor>();
            floors.Add(new Floor
            {
                Id = 1,
                Andar = 2,
                Letra = "A"
            });

            floors.Add(new Floor
            {
                Id = 2,
                Andar = 2,
                Letra = "B"
            });
            Floor f = new Floor();
            for (int i= 0; i < floors.Count; i++)
            {
                if (floors[i].Id == id)
                {
                 f = floors[i];
                }

            }
            return f;
        }

        [HttpPost]
        public async Task<ActionResult<Model.Floor>> Post(Model.Floor floor)
        {
            Floor fl = new()
            {
                Id = 1,
                Andar = 2,
                Letra = "A"

            };

            return CreatedAtAction(nameof(Get), new { id = fl.Id });
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<List<Floor>>> UpdatePut(int id, Floor floor)
        {
            var floors = new List<Floor>();
            floors.Add(new Floor
            {
                Id = 1,
                Andar = 2,
                Letra = "A"
            });

            floors.Add(new Floor
            {
                Id = 2,
                Andar = 2,
                Letra = "B"
            });

            for (int i = 0; i < floors.Count; i++)
            {
                if (id == floors[i].Id)
                {
                    floors[i] = floor;
                }
            }

            return floors;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<List<Floor>>> DeleteFloor(int id, Floor floor)
        {
            var floors = new List<Floor>();
            floors.Add(new Floor
            {
                Id = 1,
                Andar = 2,
                Letra = "A"
            });

            floors.Add(new Floor
            {
                Id = 2,
                Andar = 2,
                Letra = "B"
            });

            for (int i = 0; i < floors.Count; i++)
            {
                if (id == floors[i].Id)
                {
                    floors.Remove(floors[i]);
                }

            }

            return floors;
        }
    }
}
