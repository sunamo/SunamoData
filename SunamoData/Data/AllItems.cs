namespace SunamoData.Data;

/// <summary>
/// By default, all verses or anything else will always be taken.
/// </summary>
public class AllItems
{
    /// <summary>
    /// Gets or sets a value indicating whether all items should be taken.
    /// By default true, all verses or anything else will always be taken.
    /// </summary>
    public bool All { get; set; } = true;

    /// <summary>
    /// Gets or sets the starting index.
    /// </summary>
    public int From { get; set; } = 0;

    /// <summary>
    /// Gets or sets the ending index.
    /// </summary>
    public int To { get; set; } = 0;
}