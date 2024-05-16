using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Fungibles;

public class Fungible
{
	[JsonPropertyName("fungible_id")]
	public string FungibleId { get; set; } = "";

	[JsonPropertyName("name")]
	public string Name { get; set; } = "";

	[JsonPropertyName("symbol")]
	public string? Symbol { get; set; }

	[JsonPropertyName("decimals")]
	public int Decimals { get; set; }

	[JsonPropertyName("chain")]
	public string Chain { get; set; } = "";

	[JsonPropertyName("queried_wallet_balances")]
	public IEnumerable<QueriedWalletBalance> QueriedWalletBalances { get; set; } = new List<QueriedWalletBalance>();
}