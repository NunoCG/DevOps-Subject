using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Model
{
    public class Floor
    {
        public int Id { get; set; }
        public int Andar { get; set; }
        public String Letra { get; set; }
        public List<Flat> Flats { get; set; }
    }
}
