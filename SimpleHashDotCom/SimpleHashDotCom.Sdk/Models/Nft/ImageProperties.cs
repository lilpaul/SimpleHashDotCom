using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class ImageProperties
{
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("size")]
    public decimal? Size { get; set; }

    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; } = "";
}