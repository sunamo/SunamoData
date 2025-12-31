namespace SunamoData.Data;

public class OTS
{
    public object First;
    public object Second;

    public static OTS Get(object first, object second)
    {
        var result = new OTS();
        result.First = first;
        result.Second = second;
        return result;
    }

    public override string ToString()
    {
        return First + "" + Second;
    }
}