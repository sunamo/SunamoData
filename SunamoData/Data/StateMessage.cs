namespace SunamoData.Data;

/// <summary>
/// Represents a state message with a type and text content.
/// </summary>
public class StateMessage
{
    /// <summary>
    /// Gets or sets the message text.
    /// </summary>
    protected string Message { get; set; }

    /// <summary>
    /// Gets or sets the message type.
    /// </summary>
    protected string MessageType { get; set; } = "Information";

    /// <summary>
    /// Initializes a new instance of the <see cref="StateMessage"/> class.
    /// </summary>
    /// <param name="messageType">The type of the message.</param>
    /// <param name="message">The message text.</param>
    public StateMessage(string messageType, string message)
    {
        this.MessageType = messageType;
        this.Message = message;
    }

    /// <summary>
    /// Gets the type of the message.
    /// </summary>
    public string TypeOfMessage => MessageType;

    /// <summary>
    /// Gets the text content of the message.
    /// </summary>
    public string TextMessage => Message;
}