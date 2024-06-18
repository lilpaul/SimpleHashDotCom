using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class ModelProperties
{
    [JsonPropertyName("size")]
    public decimal? Size { get; set; }

    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }
}