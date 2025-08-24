namespace Test.utils_HackerRank
{
    public class helperFunc_SwapNodes
    {
        public List<List<int>> SwapNode(int numOfNodes, int[][] arrCreateNodes, int[] queries)
        {
            List<List<int>> result = new List<List<int>>();

            TreeNodeNew root = BuildTree(arrCreateNodes);
            //Tree.TranverseTree(root);

            for (int i = 0; i < queries.Length; i++)
            {
                swapAtDepth(root, 1, queries[i]);
                List<int> listTranverse = new List<int>();
                Tree.TranverseTree(root, listTranverse);
                result.Add(listTranverse);
            }

            return result;
        }

        public static void swapAtDepth(TreeNodeNew? node, int currentDepth, int query)
        {
            if (node == null) return;

            if (currentDepth % query == 0)
            {
                TreeNodeNew temp = node.left;
                node.left = node.right;
                node.right = temp;
            }

            swapAtDepth(node.left, currentDepth + 1, query);
            swapAtDepth(node.right, currentDepth + 1, query);
        }

        public static TreeNodeNew BuildTree(int[][] arrCreateNodes)
        {
            Tree tree = new Tree(new TreeNodeNew(1));
            Queue<TreeNodeNew> queue = new Queue<TreeNodeNew>();
            queue.Enqueue(tree._root);

            for (int i = 0; i < arrCreateNodes.Length; i++)
            {
                TreeNodeNew currentNode = queue.Dequeue();
                int leftIndex = arrCreateNodes[i][0];
                int rightIndex = arrCreateNodes[i][1];

                if (leftIndex != -1)
                {
                    currentNode.left = new TreeNodeNew(leftIndex);
                    queue.Enqueue(currentNode.left);
                }

                if (rightIndex != -1)
                {
                    currentNode.right = new TreeNodeNew(rightIndex);
                    queue.Enqueue(currentNode.right);
                }

            }

            return tree._root;
        }

        public class TreeNodeNew
        {
            public int _data { get; set; }
            public TreeNodeNew? left;
            public TreeNodeNew? right;

            public TreeNodeNew(int data)
            {
                _data = data;
                left = null;
                right = null;
            }
        }

        public class Tree
        {
            public TreeNodeNew? _root;
            public Tree(TreeNodeNew root)
            {
                _root = root;
            }

            public static void TranverseTree(TreeNodeNew? root, List<int> listTranverse)
            {
                if (root is null)
                    return;

                TranverseTree(root.left, listTranverse);
                listTranverse.Add(root._data);
                TranverseTree(root.right, listTranverse);
            }
        }
    }
}