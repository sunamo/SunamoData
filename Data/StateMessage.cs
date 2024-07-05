namespace SunamoData.Data;

public class StateMessage
{
    protected string mt = "Information";
    protected string message = null;

    public StateMessage(string mt, string message)
    {
        this.mt = mt;
        this.message = message;
    }

    public string TypeOfMessage
    {
        get
        {
            return mt;
        }
    }

    public string TextMessage
    {
        get
        {
            return message;
        }
    }
}
