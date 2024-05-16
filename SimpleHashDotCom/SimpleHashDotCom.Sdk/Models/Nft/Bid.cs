using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Bid
{
	[JsonPropertyName("id")]
	public string Id { get; set; } = "";

	[JsonPropertyName("quantity")]
	public long? Quantity { get; set; }

	[JsonPropertyName("price")]
	public long Price { get; set; }

	[JsonPropertyName("timestamp")]
	public DateTime Timestamp { get; set; }

	[JsonPropertyName("bidder_address")]
	public string BidderAddress { get; set; } = "";

	[JsonPropertyName("marketplace_id")]
	public string MarketplaceId { get; set; } = "";

	[JsonPropertyName("collection_id")]
	public string? CollectionId { get; set; }

	[JsonPropertyName("nft_id")]
	public string NftId { get; set; } = "";

	[JsonPropertyName("payment_token")]
	public PaymentToken PaymentToken { get; set; } = new();

	[JsonPropertyName("expiration_timestamp")]
	public DateTime? ExpirationTimestamp { get; set; }
}