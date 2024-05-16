using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class MetadataAttribute
{
	[JsonPropertyName("trait_type")]
	public string? TraitType { get; set; }

	[JsonPropertyName("value")]
	public string Value { get; set; } = "";

	[JsonPropertyName("display_type")]
	public string? DisplayType { get; set; }
}