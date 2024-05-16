using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Fungibles;

public class QueriedWalletBalance
{
	[JsonPropertyName("address")]
	public string Address { get; set; } = "";

	[JsonPropertyName("quantity")]
	public long Quantity { get; set; }

	[JsonPropertyName("quantity_string")]
	public string QuantityString { get; set; } = "";

	[JsonPropertyName("first_transferred_date")]
	public DateTime FirstTransferredDate { get; set; }

	[JsonPropertyName("last_transferred_date")]
	public DateTime LastTransferredDate { get; set; }

	[JsonPropertyName("subaccounts")]
	public IEnumerable<SubAccount> Subaccounts { get; set; } = new List<SubAccount>();
}