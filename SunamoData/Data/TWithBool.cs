namespace SunamoData.Data;

public class TWithBool<T> //: ITWithDt<T>
{
    public T Value { get; set; } = default;
    public bool Bool { get; set; }
}