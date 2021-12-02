using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Model
{
    public class Domain
    {
        public float pricePerFlat() { return 0; }

        public static double pricePerOwner(Owner o)
        {
            double price = 0;
            for (int i = 0; i < o.Flats.Count; i++)
            {
                price = price + (o.Flats[i].size * o.Flats[i].building.Valor);
            }
            return price;
        }

        public double pricePerFlat(Building buildingPrice, Flat flatSize)
        {
            return buildingPrice.Valor * flatSize.size;
        }
    }
}

