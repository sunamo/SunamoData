namespace SunamoData.Data;

/// <summary>
/// Represents a pair of value and label strings.
/// </summary>
public class ValueLabel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValueLabel"/> class.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="label">The label.</param>
    public ValueLabel(string value, string label)
    {
        this.Value = value;
        this.Label = label;
    }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Creates a new instance of <see cref="ValueLabel"/> with the specified value and label.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="label">The label.</param>
    /// <returns>A new instance of <see cref="ValueLabel"/>.</returns>
    public static ValueLabel Get(string value, string label)
    {
        return new ValueLabel(value, label);
    }
}
