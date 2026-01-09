// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// A list of TU&lt;T, U&gt; tuples that provides access to itself as a List.
/// </summary>
/// <typeparam name="T">The type of the first value in each tuple.</typeparam>
/// <typeparam name="U">The type of the second value in each tuple.</typeparam>
public class TUList<T, U> : List<TU<T, U>>
{
    /// <summary>
    /// Gets the list as itself (convenience property for compatibility).
    /// </summary>
    public List<TU<T, U>> List => this;
}