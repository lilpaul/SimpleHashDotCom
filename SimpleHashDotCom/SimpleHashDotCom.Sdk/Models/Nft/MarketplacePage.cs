using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class MarketplacePage
{
	[JsonPropertyName("marketplace_id")]
	public string MarketplaceId { get; set; } = "";

	[JsonPropertyName("marketplace_name")]
	public string MarketplaceName { get; set; } = "";

	[JsonPropertyName("marketplace_collection_id")]
	public string MarketplaceCollectionId { get; set; } = "";

	[JsonPropertyName("nft_url")]
	public string? NftUrl { get; set; }

	[JsonPropertyName("collection_url")]
	public string CollectionUrl { get; set; } = "";

	[JsonPropertyName("verified")]
	public bool? Verified { get; set; }
}