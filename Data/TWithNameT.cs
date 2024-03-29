public class TWithNameT<T>
{
    /// <summary>
    ///     Just first 5. letters
    /// </summary>
    public string name = string.Empty;

    public T t;

    public TWithName()
    {
    }

    public TWithName(string name, T t)
    {
        this.name = name;
        this.t = t;
    }


    public override string ToString()
    {
        return name;
    }

    public static TWithName<T> Get(string nameCb)
    {
        return new TWithName<T> { name = nameCb };
    }
}