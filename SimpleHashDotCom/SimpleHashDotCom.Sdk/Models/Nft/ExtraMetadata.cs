using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class ExtraMetadata
{
	[JsonPropertyName("attributes")]
	public IEnumerable<MetadataAttribute> Attributes { get; set; } = new List<MetadataAttribute>();

	[JsonPropertyName("image_original_url")]
	public string? ImageOriginalUrl { get; set; }

	[JsonPropertyName("animation_original_url")]
	public string? AnimationOriginalUrl { get; set; }

	[JsonPropertyName("metadata_original_url")]
	public string? MetadataOriginalUrl { get; set; }
}