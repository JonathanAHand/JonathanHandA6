using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace JonathanHandA6
{
    public class Book
    {
        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        [JsonPropertyName("Author")]
        public string? Author { get; set; }

        [JsonPropertyName("Page Length")]
        public int PageLength { get; set; }

        [JsonPropertyName("Genre")]
        public string? Genre { get; set; }

        [JsonPropertyName("Year Published")]
        public int YearPublished { get; set; }

        [JsonPropertyName("MSRP")]
        public decimal Msrp { get; set; }

        public override string ToString() => $"{Title} — {Author}";
    }
}

