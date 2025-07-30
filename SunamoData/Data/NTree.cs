namespace SunamoData.Data;
//public delegate void Action<T>(T nodeData);

//public delegate void A();
/*
public delegate void A();
*/

public class NTree<T>
{
    public LinkedList<NTree<T>> children;
    public T data;

    public NTree(T data)
    {
        this.data = data;
        children = new LinkedList<NTree<T>>();
    }

    public NTree<T> AddChild(T data)
    {
        var child = new NTree<T>(data);
        children.AddFirst(child);
        return child;
    }

    public NTree<T> GetChild(int i)
    {
        foreach (var n in children)
            if (--i == 0)
                return n;
        return null;
    }

    public void Traverse(NTree<T> node, Action<T> visitor)
    {
        visitor(node.data);
        foreach (var kid in node.children)
            Traverse(kid, visitor);
    }
}