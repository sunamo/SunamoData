namespace SunamoData.Data;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
//public delegate void Action<T>(T nodeData);

//public delegate void A();
/*
public delegate void A();
*/

public class NTree<T>
{
    public LinkedList<NTree<T>> Children;
    public T Data;

    public NTree(T data)
    {
        this.Data = data;
        Children = new LinkedList<NTree<T>>();
    }

    public NTree<T> AddChild(T data)
    {
        var child = new NTree<T>(data);
        Children.AddFirst(child);
        return child;
    }

    public NTree<T> GetChild(int i)
    {
        foreach (var n in Children)
            if (--i == 0)
                return n;
        return null;
    }

    public void Traverse(NTree<T> node, Action<T> visitor)
    {
        visitor(node.Data);
        foreach (var kid in node.Children)
            Traverse(kid, visitor);
    }
}