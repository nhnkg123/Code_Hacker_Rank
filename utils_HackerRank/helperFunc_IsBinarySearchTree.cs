namespace Test.utils_HackerRank
{
    public class helperFunc_IsBinarySearchTree
    {
        public class BinaryTreeNode
        {
            public int _data;
            public BinaryTreeNode? left;
            public BinaryTreeNode? right;

            public BinaryTreeNode(int data)
            {
                _data = data;
                left = null;
                right = null;
            }
        }

        public class BinaryTree
        {
            public BinaryTreeNode? _root;

            public BinaryTree(BinaryTreeNode root)
            {
                _root = root;
            }

            public void TranversTree(BinaryTreeNode? current)
            {
                if (current == null)
                    return;

                TranversTree(current.left);
                Console.Write($"{current._data}" + " ");
                TranversTree(current.right);
            }

            // optimize by store count on each Node ==>  thinking
            public BinaryTreeNode AddNode(BinaryTreeNode? current, int data)
            {
                BinaryTreeNode newNode = new BinaryTreeNode(data);

                if (current == null)
                {
                    return new BinaryTreeNode(data);
                }

                if (CountNodeTree(current.left) <= CountNodeTree(current.right))
                {
                    current.left = AddNode(current.left, data);
                }
                else
                {
                    current.right = AddNode(current.right, data);
                }

                return current;
            }

            public BinaryTreeNode AddBinaryTreeNode(BinaryTreeNode? current, int data)
            {
                BinaryTreeNode newNode = new BinaryTreeNode(data);

                if (current == null)
                {
                    return new BinaryTreeNode(data);
                }

                if (data < current._data)
                {
                    current.left = AddNode(current.left, data);
                }
                else
                {
                    current.right = AddNode(current.right, data);
                }

                return current;
            }

            public int CountNodeTree(BinaryTreeNode? current)
            {
                if (current == null)
                {
                    return 0;
                }

                int countLeft = CountNodeTree(current.left);
                int countRight = CountNodeTree(current.right);

                return 1 + countLeft + countRight;
            }

            public bool CheckIsBinaryTree(
                BinaryTreeNode? current,
                BinaryTreeNode? parent = null,
                bool isLeft = false,
                bool isRight = false
            )
            {
                if (current == null)
                {
                    return true;
                }

                if (parent != null &&
                    (parent._data <= current._data && isLeft == true || parent._data > current._data && isRight == true)
                )
                {
                    return false;
                }

                bool left = CheckIsBinaryTree(current.left, current, true, false);
                bool right = CheckIsBinaryTree(current.right, current, false, true);

                return left && right;
            }
        }
    }
}