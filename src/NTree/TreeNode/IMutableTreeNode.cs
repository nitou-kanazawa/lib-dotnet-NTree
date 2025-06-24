using System.Collections.Generic;

namespace NTree {
    public interface IMutableTreeNode<TNode> : ITreeNode<TNode>
        where TNode : IMutableTreeNode<TNode> {
        void AddChild(TNode child);
        void InsertChild(int index, TNode child);
        void RemoveChild(TNode child);
        IEnumerable<TNode> ClearChildren();
    }
}