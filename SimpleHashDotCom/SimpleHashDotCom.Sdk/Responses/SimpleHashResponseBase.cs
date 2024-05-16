using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Responses;

public abstract class SimpleHashResponseBase
{
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; set; }

	[JsonPropertyName("next")]
	public string? Next { get; set; }

	[JsonPropertyName("previous")]
	public string? Previous { get; set; }
}