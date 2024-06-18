using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class AudioProperties
{
    [JsonPropertyName("duration")]
    public decimal? Duration { get; set; }

    [JsonPropertyName("audio_coding")]
    public string? AudioCoding { get; set; }

    [JsonPropertyName("size")]
    public decimal? Size { get; set; }

    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }
}