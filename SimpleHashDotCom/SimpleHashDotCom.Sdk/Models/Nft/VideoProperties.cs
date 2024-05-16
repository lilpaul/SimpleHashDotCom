using System.Text.Json.Serialization;

namespace SimpleHashDotCom.Sdk.Models.Nft;

public class VideoProperties
{
	[JsonPropertyName("width")]
	public int Width { get; set; }

	[JsonPropertyName("height")]
	public int Height { get; set; }

	[JsonPropertyName("duration")]
	public decimal? Duration { get; set; }

	[JsonPropertyName("video_coding")]
	public string? VideoCoding { get; set; }

	[JsonPropertyName("audio_coding")]
	public string? AudioCoding { get; set; }

	[JsonPropertyName("size")]
	public long? Size { get; set; }

	[JsonPropertyName("mime_type")]
	public string? MimeType { get; set; }
}