namespace SunamoData.Data;

public class StateMessage
{
    protected string message;
    protected string mt = "Information";

    public StateMessage(string mt, string message)
    {
        this.mt = mt;
        this.message = message;
    }

    public string TypeOfMessage => mt;

    public string TextMessage => message;
}