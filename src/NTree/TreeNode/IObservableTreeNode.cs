using System;

namespace NTree {

    /// <summary>
    /// A node in a tree that can be observed.
    /// </summary>
    /// <typeparam name="TNode">The type of the node.</typeparam>
    public interface IObservableTreeNode<TNode> : ITreeNode<TNode>
        where TNode : IObservableTreeNode<TNode> {

    }



}