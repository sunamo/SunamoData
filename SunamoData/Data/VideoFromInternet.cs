// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a video from the internet with metadata.
/// </summary>
public class VideoFromInternet
{
    /// <summary>
    /// Gets or sets the file extension (e.g., "mp4", "webm").
    /// </summary>
    public string Extension { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the channel name.
    /// </summary>
    public string Channel { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the video title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the YouTube video code.
    /// </summary>
    public string YtCode { get; set; } = string.Empty;
}