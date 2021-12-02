using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Model
{
    public class Owner
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public List<Flat> Flats { get; set; }

        public Flat flat { get; set; }
    }
}
