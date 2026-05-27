using System.Collections.Generic;
using System.Linq;

namespace NTree {

    /// <summary>
    /// A node in a tree.
    /// </summary>
    /// <typeparam name="TNode">The type of the node.</typeparam>
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

