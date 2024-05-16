using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class TopBid
{
	[JsonPropertyName("marketplace_id")]
	public string MarketplaceId { get; set; } = "";

	[JsonPropertyName("value")]
	public long? Value { get; set; }

	[JsonPropertyName("payment_token")]
	public PaymentToken PaymentToken { get; set; } = new();

	[JsonPropertyName("value_usd_cents")]
	public long? ValueUsdCents { get; set; }
}