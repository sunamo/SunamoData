namespace SunamoData;

public class TUList<T, U> : List<TU<T, U>>
{
    public List<TU<T, U>> list => this;
}
