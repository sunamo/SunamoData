namespace SunamoData._sunamo;

/// <summary>
/// Collection helper methods for internal use.
/// </summary>
internal class CA
{
    /// <summary>
    /// Trims all strings in the list.
    /// </summary>
    /// <param name="list">The list of strings to trim.</param>
    /// <returns>The same list with all strings trimmed.</returns>
    internal static List<string> Trim(List<string> list)
    {
        for (var i = 0; i < list.Count; i++) list[i] = list[i].Trim();
        return list;
    }
}