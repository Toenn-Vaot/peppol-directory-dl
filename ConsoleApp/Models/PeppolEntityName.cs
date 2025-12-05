using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public class PeppolEntityName
{
    [JsonPropertyName("lang")]
    public string Lang { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}