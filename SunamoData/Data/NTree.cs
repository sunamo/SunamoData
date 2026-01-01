namespace SunamoData.Data;

/// <summary>
/// Represents a node in an N-ary tree structure.
/// </summary>
/// <typeparam name="T">The type of data stored in each node.</typeparam>
public class NTree<T>
{
    /// <summary>
    /// Gets or sets the collection of child nodes.
    /// </summary>
    public LinkedList<NTree<T>> Children { get; set; }

    /// <summary>
    /// Gets or sets the data stored in this node.
    /// </summary>
    public T Data { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NTree{T}"/> class with the specified data.
    /// </summary>
    /// <param name="data">The data to store in this node.</param>
    public NTree(T data)
    {
        this.Data = data;
        Children = new LinkedList<NTree<T>>();
    }

    /// <summary>
    /// Adds a new child node with the specified data.
    /// </summary>
    /// <param name="data">The data for the new child node.</param>
    /// <returns>The newly created child node.</returns>
    public NTree<T> AddChild(T data)
    {
        var child = new NTree<T>(data);
        Children.AddFirst(child);
        return child;
    }

    /// <summary>
    /// Gets the child node at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index of the child to retrieve.</param>
    /// <returns>The child node at the specified index, or null if not found.</returns>
    public NTree<T>? GetChild(int index)
    {
        foreach (var childNode in Children)
            if (--index == 0)
                return childNode;
        return null;
    }

    /// <summary>
    /// Traverses the tree starting from the specified node, applying the visitor action to each node.
    /// </summary>
    /// <param name="node">The starting node for traversal.</param>
    /// <param name="visitor">The action to apply to each node's data.</param>
    public void Traverse(NTree<T> node, Action<T> visitor)
    {
        visitor(node.Data);
        foreach (var child in node.Children)
            Traverse(child, visitor);
    }
}