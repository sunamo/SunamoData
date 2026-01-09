// variables names: ok
namespace SunamoData._sunamo;

/// <summary>
/// String splitting helper methods for internal use.
/// </summary>
internal class SHSplit
{
    /// <summary>
    /// Splits a string by the specified delimiters, removing empty entries.
    /// </summary>
    /// <param name="text">The text to split.</param>
    /// <param name="delimiters">The delimiter strings.</param>
    /// <returns>A list of non-empty trimmed parts.</returns>
    internal static List<string> Split(string text, params string[] delimiters)
    {
        return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    /// <summary>
    /// Splits a string by the specified character delimiters, removing empty entries.
    /// </summary>
    /// <param name="text">The text to split.</param>
    /// <param name="delimiters">The delimiter characters.</param>
    /// <returns>A list of non-empty trimmed parts.</returns>
    internal static List<string> SplitChar(string text, params char[] delimiters)
    {
        return Split(StringSplitOptions.RemoveEmptyEntries, text,
            delimiters.ToList().ConvertAll(character => character.ToString()).ToArray());
    }

    /// <summary>
    /// Splits a string by the specified delimiters with custom split options.
    /// </summary>
    /// <param name="stringSplitOptions">Options for splitting.</param>
    /// <param name="text">The text to split.</param>
    /// <param name="delimiters">The delimiter strings.</param>
    /// <returns>A list of trimmed parts.</returns>
    internal static List<string> Split(StringSplitOptions stringSplitOptions, string text, params string[] delimiters)
    {
        if (delimiters == null || delimiters.Count() == 0) throw new Exception("NoDelimiterDetermined");
        var result = text.Split(delimiters, stringSplitOptions).ToList();
        CA.Trim(result);
        if (stringSplitOptions == StringSplitOptions.RemoveEmptyEntries)
            result = result.Where(part => part.Trim() != string.Empty).ToList();

        return result;
    }
}