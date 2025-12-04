using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public class PeppolBusinessCard
{
    [JsonPropertyName("pid")]
    public string Pid { get; set;}

    [JsonPropertyName("entities")]
    public IEnumerable<PeppolEntity> Entities { get; set; }

    [JsonPropertyName("docTypes")]
    public IEnumerable<PeppolDocumentType> DocumentTypes { get; set; }
}