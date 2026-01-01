namespace SunamoData.Data;

/// <summary>
/// Represents a music title with artist, title, and remix information.
/// </summary>
public class MusicTitle
{
    /// <summary>
    /// Gets or sets the artist name.
    /// </summary>
    public string Artist { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the remix information.
    /// </summary>
    public string Remix { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the title of the song.
    /// </summary>
    public string Title { get; set; } = string.Empty;
}
