namespace SunamoData.Data;

/// <summary>
/// Represents arguments for a replacement operation with old and new value labels.
/// </summary>
public class ReplaceArgs
{
    /// <summary>
    /// Gets or sets the initial message displayed to the user.
    /// </summary>
    public string InitialMessage { get; set; }

    /// <summary>
    /// Gets or sets the label for the new value.
    /// </summary>
    public string LblNewValue { get; set; }

    /// <summary>
    /// Gets or sets the label for the old value.
    /// </summary>
    public string LblOldValue { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReplaceArgs"/> class.
    /// </summary>
    /// <param name="initialMessage">The initial message displayed to the user.</param>
    /// <param name="lblOldValue">The label for the old value.</param>
    /// <param name="lblNewValue">The label for the new value.</param>
    public ReplaceArgs(string initialMessage, string lblOldValue, string lblNewValue)
    {
        this.InitialMessage = initialMessage;
        this.LblOldValue = lblOldValue;
        this.LblNewValue = lblNewValue;
    }
}
