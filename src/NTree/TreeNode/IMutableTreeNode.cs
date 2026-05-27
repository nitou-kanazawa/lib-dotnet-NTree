using System.Collections.Generic;

namespace NTree {

    /// <summary>
    /// A mutable node in a tree.
    /// </summary>
    /// <typeparam name="TNode">The type of the node.</typeparam>
    public interface IMutableTreeNode<TNode> : ITreeNode<TNode>
        where TNode : IMutableTreeNode<TNode> {

        TNode AddChild(TNode child);
        TNode InsertChild(int index, TNode child);
        TNode RemoveChild(TNode child);
        IEnumerable<TNode> ClearChildren();
    }
}