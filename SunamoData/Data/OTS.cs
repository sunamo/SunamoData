// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a pair of objects (Object, Type, String - OTS).
/// </summary>
public class OTS
{
    /// <summary>
    /// Gets or sets the first object.
    /// </summary>
    public object First { get; set; } = new();

    /// <summary>
    /// Gets or sets the second object.
    /// </summary>
    public object Second { get; set; } = new();

    /// <summary>
    /// Creates a new OTS instance with the specified first and second objects.
    /// </summary>
    /// <param name="first">The first object.</param>
    /// <param name="second">The second object.</param>
    /// <returns>A new OTS instance.</returns>
    public static OTS Get(object first, object second)
    {
        var result = new OTS();
        result.First = first;
        result.Second = second;
        return result;
    }

    /// <summary>
    /// Returns a string representation combining both objects.
    /// </summary>
    /// <returns>A string combining First and Second.</returns>
    public override string ToString()
    {
        return First + "" + Second;
    }
}