namespace SunamoData.Data;

public class ReplaceArgs
{
    public string initialMessage;
    public string lblNewValue;
    public string lblOldValue;

    public ReplaceArgs(string initialMessage, string lblOldValue, string lblNewValue)
    {
        this.initialMessage = initialMessage;
        this.lblOldValue = lblOldValue;
        this.lblNewValue = lblNewValue;
    }
}