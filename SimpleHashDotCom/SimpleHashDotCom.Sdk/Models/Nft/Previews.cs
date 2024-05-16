using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Previews
{
	[JsonPropertyName("image_small_url")]
	public string? ImageSmallUrl { get; set; }

	[JsonPropertyName("image_medium_url")]
	public string? ImageMediumUrl { get; set; }

	[JsonPropertyName("image_large_url")]
	public string? ImageLargeUrl { get; set; }

	[JsonPropertyName("image_opengraph_url")]
	public string? ImageOpengraphUrl { get; set; }

	[JsonPropertyName("blurhash")]
	public string? BlurHash { get; set; }

	[JsonPropertyName("predominant_color")]
	public string? PredominantColor { get; set; }
}