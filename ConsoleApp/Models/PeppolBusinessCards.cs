using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public class PeppolBusinessCards
{
    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("participantCount")]
    public int ParticipantCount { get; set; }

    [JsonPropertyName("codeListSupported")]
    public string CodeListSupported { get; set; }

    [JsonPropertyName("creationdt")]
    public DateTime CreationDate { get; set; }

    [JsonPropertyName("bc")]
    public List<PeppolBusinessCard> BusinessCards { get; set; }
}