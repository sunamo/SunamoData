namespace SunamoData.Data;

/// <summary>
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
public abstract class Parsing<T1, T2>
{
    public T1 FirstValue = default;
    public T2 SecondValue = default;
    public abstract void ParsujM(string content);
}