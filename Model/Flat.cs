using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Model
{
    public class Flat
    {
        public int id { get; set; }
        public int floorsNumber { get; set; }
        public String floor { get; set; }
        public String street { get; set; }
        public String postcode { get; set; }
        public float size { get; set; }
        public Owner owner { get; set; }
        public Building building { get; set; }
    }
}
