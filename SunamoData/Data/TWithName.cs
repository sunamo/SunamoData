namespace SunamoData.Data;

/// <summary>
/// Factory class for creating TWithNameT instances.
/// </summary>
public class TWithName
{
    /// <summary>
    /// Creates a new TWithNameT instance with the specified name and object type.
    /// </summary>
    /// <param name="name">The name for the instance.</param>
    /// <returns>A new TWithNameT&lt;object&gt; instance.</returns>
    public static TWithNameT<object> Get(string name)
    {
        return new TWithNameT<object> { Name = name };
    }
}