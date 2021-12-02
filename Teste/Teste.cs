using System.Collections.Generic;
using Code;
using Code.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void pricePerOwner_FlatPricePerOwner()
        {
            Owner o = new Owner();
            o.Flats = new List<Flat>();
            o.Flats.Add(new Flat());
            o.Flats.Add(new Flat());
            o.Flats.Add(new Flat());
            o.Flats[0].building = new Building();
            o.Flats[0].building.Valor = 2;
            o.Flats[0].size = 200;
            o.Flats[1].building = new Building();
            o.Flats[1].building.Valor = 2;
            o.Flats[1].size = 300;
            o.Flats[2].building = new Building();
            o.Flats[2].building.Valor = 5;
            o.Flats[2].size = 200;
            Assert.AreEqual(2000, Domain.pricePerOwner(o));

            Owner o1 = new Owner();
            o1.Flats = new List<Flat>();
            o1.Flats.Add(new Flat());
            o1.Flats[0].building = new Building();
            o1.Flats[0].building.Valor = 0;
            o1.Flats[0].size = 0;
            Assert.AreEqual(0, Domain.pricePerOwner(o1));

        }

        [TestMethod]
        public void pricePerFlat_MultiplyPriceAndSize_ReturnAFloatNumber()
        {
            // Arrange
            var domain = new Domain();

            // Act
            double result = domain.pricePerFlat(new Building { Valor = 4.5 }, new Flat { size = 200 });

            // Assert
            Assert.AreEqual(result, 900);
        }
    }
}
