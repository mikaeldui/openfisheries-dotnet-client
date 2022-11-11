using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace OpenFisheries
{
    public class OpenFisheriesClient : IDisposable
    {
        private HttpClient _httpClient;

        public OpenFisheriesClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.openfisheries.org/api/", UriKind.Absolute)
            };
        }

        /// <summary>
        /// annual fishery landings data.
        /// </summary>
        public async Task<Landing[]?> GetLandingsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Landing[]>("landings.json");
        }

        /// <summary>
        /// annual fishery landings data.
        /// </summary>
        public async Task<Landing[]?> GetLandingsAsync(Country country)
        {
            return await _httpClient.GetFromJsonAsync<Landing[]>($"landings/countries/{country.Iso3c}.json");
        }

        /// <summary>
        /// annual fishery landings data.
        /// </summary>
        public async Task<Landing[]?> GetLandingsByCountryCodeAsync(string countryCode)
        {
            return await _httpClient.GetFromJsonAsync<Landing[]>($"landings/countries/{countryCode}.json");
        }

        /// <summary>
        /// annual fishery landings data.
        /// </summary>
        public async Task<Landing[]?> GetLandingsAsync(Species species)
        {
            return await _httpClient.GetFromJsonAsync<Landing[]>($"landings/species/{species.Interagency3AlphaCode}.json");
        }

        /// <summary>
        /// annual fishery landings data.
        /// </summary>
        public async Task<Landing[]?> GetLandingsBySpeciesAsync(string interagency3alphaCode)
        {
            return await _httpClient.GetFromJsonAsync<Landing[]>($"landings/species/{interagency3alphaCode}.json");
        }

        /// <summary>
        /// Get a complete list of all countries that can be used in API calls
        /// </summary>
        public async Task<Country[]?> GetCountriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Country[]>("landings/countries.json");
        }

        /// <summary>
        /// Get a complete list of all species that can be used in API calls
        /// </summary>
        public async Task<Species[]?> GetSpeciesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Species[]>("landings/species.json");
        }

        public void Dispose() => ((IDisposable)_httpClient).Dispose();
    }
}
