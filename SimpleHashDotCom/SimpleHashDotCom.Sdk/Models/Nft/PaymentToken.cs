using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class PaymentToken
{
	[JsonPropertyName("payment_token_id")]
	public string PaymentTokenId { get; set; } = "";

	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("symbol")]
	public string? Symbol { get; set; }

	[JsonPropertyName("address")]
	public string? Address { get; set; }

	[JsonPropertyName("decimals")]
	public int Decimals { get; set; }
}