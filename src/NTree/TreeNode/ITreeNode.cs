using System.Collections.Generic;
using System.Linq;

namespace NTree {
    public interface ITreeNode<TNode>
        where TNode : ITreeNode<TNode> {

        TNode? Parent { get; }
        IEnumerable<TNode> Children { get; }
    }


    public static class TreeNodeExtensions {

        public static bool IsRoot<TNode>(this ITreeNode<TNode> node)
            where TNode : ITreeNode<TNode> {
            return node.Parent is null;
        }

        public static bool IsLeaf<TNode>(this ITreeNode<TNode> node)
            where TNode : ITreeNode<TNode> {
            return !node.Children.Any();
        }
    }
}

