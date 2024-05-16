using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class OtherProperties
{
	[JsonPropertyName("size")]
	public long? Size { get; set; }

	[JsonPropertyName("mime_type")]
	public string? MimeType { get; set; }
}