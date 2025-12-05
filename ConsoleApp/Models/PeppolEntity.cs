using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public class PeppolEntity
{
    [JsonPropertyName("names")]
    public IEnumerable<PeppolEntityName> Names { get; set; }

    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }

    [JsonPropertyName("regdate")]
    public DateOnly RegDate { get; set;}
}