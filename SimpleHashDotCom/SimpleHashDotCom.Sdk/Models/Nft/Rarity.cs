using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class Rarity
{
	[JsonPropertyName("rank")]
	public int? Rank { get; set; }

	[JsonPropertyName("score")]
	public decimal? Score { get; set; }

	[JsonPropertyName("unique_attributes")]
	public int? UniqueAttributes { get; set; }
}