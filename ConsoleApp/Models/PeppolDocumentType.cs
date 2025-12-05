using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public class PeppolDocumentType
{
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
    [JsonPropertyName("scheme")]
    public string Scheme { get; set; }
    [JsonPropertyName("state")]
    public string State { get; set; }
    [JsonPropertyName("value")]
    public string Value { get; set; }
}