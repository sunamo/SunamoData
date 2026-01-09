// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents the result of parsing with convention, containing succeeded and failed items.
/// </summary>
/// <typeparam name="T">The first key type for succeeded items.</typeparam>
/// <typeparam name="U">The second key type for succeeded items.</typeparam>
/// <typeparam name="Z">The type of parsed items.</typeparam>
public class ConventionParseResult<T, U, Z> where T : notnull where U : notnull
{
    /// <summary>
    /// Gets or sets the list of items that failed to parse.
    /// </summary>
    public List<Z> Failed { get; set; } = new();

    /// <summary>
    /// Gets or sets the dictionary of successfully parsed items organized by two levels of keys.
    /// </summary>
    public Dictionary<T, Dictionary<U, List<Z>>> Succeeded { get; set; } = new();
}