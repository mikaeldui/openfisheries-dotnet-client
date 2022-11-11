using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenFisheries.Tests
{
    [TestClass]
    public class OpenFiesheriesClientTests
    {
        [TestMethod]
        public async Task GetLandingsAsync()
        {
            using OpenFisheriesClient client = new();
            var landings = await client.GetLandingsAsync();
            Assert.IsTrue(landings.Length > 0);
        }

        [TestMethod]
        public async Task GetSpeciesAsync()
        {
            using OpenFisheriesClient client = new();
            var species = await client.GetSpeciesAsync();
            Assert.IsTrue(species.Length > 0);
        }

        [TestMethod]
        public async Task GetCountriesAsync()
        {
            using OpenFisheriesClient client = new();
            var countries = await client.GetCountriesAsync();
            Assert.IsTrue(countries.Length > 0);
        }

        [TestMethod]
        public async Task GetLandingsByCountryAsync()
        {
            using OpenFisheriesClient client = new();
            var countries = await client.GetCountriesAsync();
            var landings = await client.GetLandingsAsync(countries.First());
            Assert.IsTrue(landings.Length > 0);
        }

        [TestMethod]
        public async Task GetLandingsBySpeciesAsync()
        {
            using OpenFisheriesClient client = new();
            var species = await client.GetSpeciesAsync();
            var landings = await client.GetLandingsAsync(species.First());
            Assert.IsTrue(landings.Length > 0);
        }
    }
}
