namespace SunamoData.Data;

public class ReplaceArgs
{
    public string InitialMessage;
    public string LblNewValue;
    public string LblOldValue;

    public ReplaceArgs(string initialMessage, string lblOldValue, string lblNewValue)
    {
        this.InitialMessage = initialMessage;
        this.LblOldValue = lblOldValue;
        this.LblNewValue = lblNewValue;
    }
}