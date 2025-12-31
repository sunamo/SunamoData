namespace SunamoData.Data;

public class TWithSizeInString<T>
{
    public string SizeS = "";
    public T Value = default;

    public override string ToString()
    {
        return Value + " (" + SizeS + ")";
    }
}