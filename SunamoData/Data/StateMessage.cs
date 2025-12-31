namespace SunamoData.Data;

public class StateMessage
{
    protected string message;
    protected string messageType = "Information";

    public StateMessage(string messageType, string message)
    {
        this.messageType = messageType;
        this.message = message;
    }

    public string TypeOfMessage => messageType;

    public string TextMessage => message;
}