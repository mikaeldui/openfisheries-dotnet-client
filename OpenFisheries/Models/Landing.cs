using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenFisheries
{
    public class Landing
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("catch")]
        public float Catch { get; set; }
    }
}
