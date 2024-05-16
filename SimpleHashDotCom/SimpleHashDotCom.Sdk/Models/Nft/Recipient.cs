using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Recipient
{
	[JsonPropertyName("address")]
	public string Address { get; set; } = "";

	[JsonPropertyName("percentage")]
	public decimal Percentage { get; set; }

	[JsonPropertyName("basis_points")]
	public int BasisPoints { get; set; }
}