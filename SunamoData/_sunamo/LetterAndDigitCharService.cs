namespace SunamoData._sunamo;

/// <summary>
/// Provides services for working with letter and digit characters.
/// </summary>
internal class LetterAndDigitCharService
{
    /// <summary>
    /// Gets or sets all characters without special characters.
    /// </summary>
    internal List<char> AllCharsWithoutSpecial { get; set; } = new();

    /// <summary>
    /// Gets or sets all characters including special characters.
    /// </summary>
    internal List<char> AllChars { get; set; } = new();

    /// <summary>
    /// Gets the list of numeric digit characters (0-9).
    /// </summary>
    internal readonly List<char> NumericChars =
        new(new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });

    /// <summary>
    /// Gets the list of lowercase letter characters (a-z).
    /// </summary>
    internal readonly List<char> LowerChars = new(new[]
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
        'w', 'x', 'y', 'z'
    });

    /// <summary>
    /// Gets the list of uppercase letter characters (A-Z).
    /// </summary>
    internal readonly List<char> UpperChars = new(new[]
    {
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
        'W', 'X', 'Y', 'Z'
    });
}