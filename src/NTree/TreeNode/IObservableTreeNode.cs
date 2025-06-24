using System;

namespace NTree {
    public interface IObservableTreeNode<TNode> : ITreeNode<TNode>
        where TNode : IObservableTreeNode<TNode> {

    }



}