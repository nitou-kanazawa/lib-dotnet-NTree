using System.Collections.Generic;

namespace NTree {

    /// <summary>
    /// A base class for tree nodes.
    /// </summary>
    /// <typeparam name="TNode">The type of the node.</typeparam>
    public abstract class TreeNodeBase<TNode> : ITreeNode<TNode>
        where TNode : TreeNodeBase<TNode> {

        public TNode? Parent { get; }
        public IEnumerable<TNode> Children { get; }
    }
}