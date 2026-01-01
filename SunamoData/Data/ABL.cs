namespace SunamoData.Data;

/// <summary>
/// Represents a pair of lists with types T and U.
/// </summary>
/// <typeparam name="T">The type of elements in the first list.</typeparam>
/// <typeparam name="U">The type of elements in the second list.</typeparam>
public class ABL<T, U>
{
    /// <summary>
    /// Gets or sets the first list.
    /// </summary>
    public List<T> First { get; set; } = new();

    /// <summary>
    /// Gets or sets the second list.
    /// </summary>
    public List<U> Second { get; set; } = new();
}
