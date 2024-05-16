using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class LastSale
{
	[JsonPropertyName("from_address")]
	public string? FromAddress { get; set; }

	[JsonPropertyName("to_address")]
	public string? ToAddress { get; set; }

	[JsonPropertyName("quantity")]
	public int Quantity { get; set; }

	[JsonPropertyName("quantity_string")]
	public string QuantityString { get; set; } = "";

	[JsonPropertyName("timestamp")]
	public DateTime Timestamp { get; set; }

	[JsonPropertyName("transaction")]
	public string Transaction { get; set; } = "";

	[JsonPropertyName("marketplace_id")]
	public string MarketplaceId { get; set; } = "";

	[JsonPropertyName("marketplace_name")]
	public string MarketplaceName { get; set; } = "";

	[JsonPropertyName("is_bundle_sale")]
	public bool IsBundleSale { get; set; }

	[JsonPropertyName("payment_token")]
	public PaymentToken? PaymentToken { get; set; }

	[JsonPropertyName("unit_price")]
	public long? UnitPrice { get; set; }

	[JsonPropertyName("total_price")]
	public long? TotalPrice { get; set; }

	[JsonPropertyName("unit_price_usd_cents")]
	public long? UnitPriceUsdCents { get; set; }
}