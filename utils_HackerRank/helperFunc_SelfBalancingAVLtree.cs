namespace Test.utils_HackerRank
{
    public class helperFunc_SelfBalancingAVLtree
    {
        public class Node_AVLTree
        {
            public int _value;
            public Node_AVLTree? _left;
            public Node_AVLTree? _right;
            public int _height;
            public int _balanceFactor;

            public Node_AVLTree(int value)
            {
                _value = value;
                _left = null;
                _right = null;
                _height = 1;
                _balanceFactor = 0;
            }
        }

        public class AVLTree
        {
            public Node_AVLTree? _root;
            public AVLTree()
            {

            }
            public AVLTree(Node_AVLTree? root)
            {
                _root = root;
            }

            public void AddNode(int newValue)
            {
                Node_AVLTree newNode = new Node_AVLTree(newValue);
                if (_root == null)
                    _root = newNode;

                Node_AVLTree newNodeTree = AddNewNode(_root, newNode);
            }
            public Node_AVLTree AddNewNode(Node_AVLTree? current, Node_AVLTree newNode)
            {
                if (current == null)
                    return newNode;

                if (newNode._value > current._value)
                {
                    current._right = AddNewNode(current._right, newNode);
                }
                else
                {
                    current._left = AddNewNode(current._left, newNode);
                }
                // Update height
                int leftHeight = current._left?._height ?? 0;
                int rightHeight = current._right?._height ?? 0;
                current._height = 1 + Math.Max(leftHeight, rightHeight);

                // Update balance factor
                current._balanceFactor = leftHeight - rightHeight;

                return current;
            }
            public Node_AVLTree balanceTree(Node_AVLTree? current)
            {
                if (current == null)
                    return null;
                if (current._left == null && current._right == null)
                    return current;
                current._left = balanceTree(current._left);
                current._right = balanceTree(current._right);

                // Recalculate height and balance factor
                int leftHeight = current._left?._height ?? 0;
                int rightHeight = current._right?._height ?? 0;
                current._height = 1 + Math.Max(leftHeight, rightHeight);
                current._balanceFactor = leftHeight - rightHeight;

                // Balance the node
                if (current._balanceFactor > 1)
                {
                    if (current._left._value > current._left._left!._value)
                        return RotateRight(current); // LL case
                    else
                    {
                        current._left = RotateLeft(current._left!); // LR case
                        return RotateRight(current);
                    }
                }
                else if (current._balanceFactor < -1)
                {
                    if (current._right._value < current._right._right!._value)
                        return RotateLeft(current); // RR case
                    else
                    {
                        current._right = RotateRight(current._right!); // RL case
                        return RotateLeft(current);
                    }
                }

                return current;
            }
            public Node_AVLTree RotateLeft(Node_AVLTree node)
            {
                Node_AVLTree newRoot = node._right!;
                Node_AVLTree temp = newRoot._left;

                newRoot._left = node;
                node._right = temp;

                // Update heights
                node._height = 1 + Math.Max(
                    node._left?._height ?? 0,
                    node._right?._height ?? 0
                );

                newRoot._height = 1 + Math.Max(
                    newRoot._left?._height ?? 0,
                    newRoot._right?._height ?? 0
                );

                // Update balance factors
                node._balanceFactor = (node._left?._height ?? 0) - (node._right?._height ?? 0);
                newRoot._balanceFactor = (newRoot._left?._height ?? 0) - (newRoot._right?._height ?? 0);

                return newRoot;
            }

            public Node_AVLTree RotateRight(Node_AVLTree node)
            {
                Node_AVLTree newRoot = node._left!;
                Node_AVLTree temp = newRoot._right;

                newRoot._right = node;
                node._left = temp;

                // Update heights
                node._height = 1 + Math.Max(
                    node._left?._height ?? 0,
                    node._right?._height ?? 0
                );
                newRoot._height = 1 + Math.Max(
                    newRoot._left?._height ?? 0,
                    newRoot._right?._height ?? 0
                );

                // Update balance factors
                node._balanceFactor = (node._left?._height ?? 0) - (node._right?._height ?? 0);
                newRoot._balanceFactor = (newRoot._left?._height ?? 0) - (newRoot._right?._height ?? 0);

                return newRoot;
            }
            public void TranversTree(Node_AVLTree? current)
            {
                if (current == null)
                    return;
                TranversTree(current._left);
                Console.Write($"({current?._value}, {current?._height}, {current?._balanceFactor})");
                TranversTree(current?._right);
            }
        }
    }
}