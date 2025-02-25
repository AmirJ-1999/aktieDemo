using Microsoft.VisualStudio.TestTools.UnitTesting;
using aktieDemo;

namespace aktieDemo.Tests
{
    [TestClass]
    public class AktieTests
    {
        [TestMethod]
        public void Aktie_Konstruktor_InitialisererNavnKorrekt()
        {
            // Arrange
            string forventetNavn = "Tesla";

            // Act
            Aktie aktie = new Aktie(forventetNavn, 500, 600, 10);

            // Assert
            Assert.AreEqual(forventetNavn, aktie.Aktienavn);
        }

        [TestMethod]
        public void Aktie_Konstruktor_InitialisererKøbskursKorrekt()
        {
            // Arrange
            double forventetKøbskurs = 500;

            // Act
            Aktie aktie = new Aktie("Tesla", forventetKøbskurs, 600, 10);

            // Assert
            Assert.AreEqual(forventetKøbskurs, aktie.Købskurs);
        }

        [TestMethod]
        public void Aktie_Konstruktor_InitialisererSalgskursKorrekt()
        {
            // Arrange
            double forventetSalgskurs = 600;

            // Act
            Aktie aktie = new Aktie("Tesla", 500, forventetSalgskurs, 10);

            // Assert
            Assert.AreEqual(forventetSalgskurs, aktie.Salgskurs);
        }

        [TestMethod]
        public void Aktie_Konstruktor_InitialisererAntalAktierKorrekt()
        {
            // Arrange
            int forventetAntal = 10;

            // Act
            Aktie aktie = new Aktie("Tesla", 500, 600, forventetAntal);

            // Assert
            Assert.AreEqual(forventetAntal, aktie.AntalAktier);
        }

        [TestMethod]
        public void Afkast_BeregnerKorrektAfkast()
        {
            // Arrange
            Aktie aktie = new Aktie("Tesla", 500, 600, 10);
            double forventetAfkast = (600 - 500) * 10;

            // Act
            double faktiskAfkast = aktie.Afkast();

            // Assert
            Assert.AreEqual(forventetAfkast, faktiskAfkast);
        }

        [TestMethod]
        public void Afkast_NegativtAfkastVedTab()
        {
            // Arrange
            Aktie aktie = new Aktie("Apple", 700, 650, 5);
            double forventetAfkast = (650 - 700) * 5;

            // Act
            double faktiskAfkast = aktie.Afkast();

            // Assert
            Assert.AreEqual(forventetAfkast, faktiskAfkast);
        }

        [TestMethod]
        public void Afkast_NulAfkastVedIngenÆndring()
        {
            // Arrange
            Aktie aktie = new Aktie("Amazon", 400, 400, 20);
            double forventetAfkast = 0;

            // Act
            double faktiskAfkast = aktie.Afkast();

            // Assert
            Assert.AreEqual(forventetAfkast, faktiskAfkast);
        }
    }
}