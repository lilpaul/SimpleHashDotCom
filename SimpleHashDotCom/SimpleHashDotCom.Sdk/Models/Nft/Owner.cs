using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Owner
{
	[JsonPropertyName("owner_address")]
	public string OwnerAddress { get; set; } = "";

	[JsonPropertyName("quantity")]
	public long Quantity { get; set; }

	[JsonPropertyName("quantity_string")]
	public string QuantityString { get; set; } = "";

	[JsonPropertyName("first_acquired_date")]
	public DateTime? FirstAcquiredDate { get; set; }

	[JsonPropertyName("last_acquired_date")]
	public DateTime LastAcquiredDate { get; set; }
}