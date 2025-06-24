# NTree 基本クラス設計図

以下は、NTreeライブラリのコアとなるツリー構造のインターフェースと実装クラスのクラス図です。

```mermaid
classDiagram
    class ITreeNode~TNode~ {
        <<interface>>
        +Parent : TNode
        +Children : IReadOnlyList~TNode~
        +IsRoot : bool
        +IsLeaf : bool
        +ChildCount : int
    }
    class TreeNode~TNode~ {
        -_parent : TNode
        -_children : List~TNode~
        +Parent : TNode
        +Children : IReadOnlyList~TNode~
        +IsRoot : bool
        +IsLeaf : bool
        +ChildCount : int
        +AddChild(child : TNode) : void
        +RemoveChild(child : TNode) : bool
    }
    TreeNode~TNode~ --|> ITreeNode~TNode~
```

---

## 解説
- **ITreeNode<TNode>**: ツリー構造の基本インターフェース。親・子・ノード状態（Root/Leaf）・子数を提供。
- **TreeNode<TNode>**: ITreeNode<TNode>を実装する基本クラス。親・子リストの管理、子の追加・削除メソッドを持つ。

ご要望に応じて拡張・修正可能です。 
