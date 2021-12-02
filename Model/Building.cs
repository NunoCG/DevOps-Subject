using Code.Model;
using System.Collections.Generic;

namespace Code
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public int FloorsNumber { get; set; }
        public string Country { get; set; }
        public List<Floor> Floors { get; set; }
        public double Valor { get; set; }
        
    }
}
