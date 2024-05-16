using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Fungibles;

public class SubAccount
{
	[JsonPropertyName("account")]
	public string Account { get; set; } = "";

	[JsonPropertyName("quantity")]
	public long Quantity { get; set; }

	[JsonPropertyName("quantity_string")]
	public string QuantityString { get; set; } = "";
}