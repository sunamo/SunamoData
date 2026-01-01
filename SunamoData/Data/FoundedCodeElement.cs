namespace SunamoData.Data;

/// <summary>
/// Represents a code element found in source code with its position information.
/// </summary>
public class FoundedCodeElement : IComparable<FoundedCodeElement>
{
    /// <summary>
    /// Gets or sets the starting position (character index) of the found element.
    /// Value is -1 if location is not known (e.g., when searching in content).
    /// </summary>
    public int From { get; set; }

    /// <summary>
    /// Gets or sets the length of the found element in characters.
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Gets or sets the line number where the element was found.
    /// </summary>
    public int Line { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FoundedCodeElement"/> class.
    /// </summary>
    /// <param name="line">The line number where the element was found.</param>
    /// <param name="from">The starting position (character index) of the found element.</param>
    /// <param name="length">The length of the found element in characters.</param>
    public FoundedCodeElement(int line, int from, int length)
    {
        Length = length;
        Line = line;
        From = from;
    }

    /// <summary>
    /// Compares this instance to another FoundedCodeElement.
    /// </summary>
    /// <param name="other">The other FoundedCodeElement to compare to.</param>
    /// <returns>Currently returns 0 (elements are considered equal).</returns>
    public int CompareTo(FoundedCodeElement? other)
    {
        return 0;
    }
}
