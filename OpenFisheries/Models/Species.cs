using System.Text.Json;
using System.Text.Json.Serialization;
using UnitedNations.Fao.Statistics.Fisheries;

namespace OpenFisheries
{
    public class Species
    {
        [JsonPropertyName("scientific_name")]
        public string ScientificName { get; set; }

        [JsonPropertyName("taxocode")]
        public string TaxonomicCode { get; set; }

        [JsonPropertyName("a3_code")]
        public string Interagency3AlphaCode { get; set; }

        [JsonPropertyName("isscaap")]
        public Isscaap? Isscaap { get; set; }

        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; }
    }
}