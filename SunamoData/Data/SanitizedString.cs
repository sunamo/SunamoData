// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a string with both its normal and sanitized versions.
/// </summary>
public class SanitizedString
{
    /// <summary>
    /// Gets or sets the normal (original) string.
    /// </summary>
    public string Normal { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sanitized (cleaned/escaped) version of the string.
    /// </summary>
    public string Sanitized { get; set; } = string.Empty;
}