using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class FirstCreated
{
	[JsonPropertyName("minted_to")]
	public string? MintedTo { get; set; }

	[JsonPropertyName("quantity")]
	public long? Quantity { get; set; }

	[JsonPropertyName("quantity_string")]
	public string? QuantityString { get; set; }

	[JsonPropertyName("timestamp")]
	public DateTime? Timestamp { get; set; }

	[JsonPropertyName("block_number")]
	public long? BlockNumber { get; set; }

	[JsonPropertyName("transaction")]
	public string? Transaction { get; set; }
}