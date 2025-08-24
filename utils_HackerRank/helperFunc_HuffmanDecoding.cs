namespace Test.utils_HackerRank
{
    public class helperFunc_HuffmanDecoding
    {
        public class TreeNode
        {
            public string _charData { get; set; }
            public int _Frep { get; set; }
            public TreeNode? left;
            public TreeNode? right;

            public TreeNode(string charData, int Frep)
            {
                _charData = charData;
                _Frep = Frep;
                left = null;
                right = null;
            }
        }

        public class TreeEncoding
        {
            public TreeNode? _root;
            public TreeEncoding(TreeNode root)
            {
                _root = root;
            }

            public TreeNode AddTreeNode(TreeNode? Node, string charData, int Frep, string edges)
            {
                if (Node == null)
                {
                    return new TreeNode(charData, Frep);
                }

                if (edges[0] == '0')
                {
                    string newEdges = edges.Substring(1);
                    Node.left = AddTreeNode(Node.left, charData, Frep, newEdges);
                }
                else
                {
                    string newEdges = edges.Substring(1);
                    Node.right = AddTreeNode(Node.right, charData, Frep, newEdges);
                }

                return Node;
            }

            public void TranverseTree(TreeNode? root)
            {
                if (root is null)
                    return;

                TranverseTree(root.left);
                Console.Write($"({root._charData}, {root._Frep})" + " ");
                TranverseTree(root.right);
            }

            public string Decode(string decodeString)
            {
                string result = "";
                TreeNode? currentNode = _root;

                foreach (char i in decodeString)
                {
                    if (i == '0')
                    {
                        currentNode = currentNode?.left;
                    }
                    else
                    {
                        currentNode = currentNode?.right;
                    }

                    if (currentNode?.left == null && currentNode?.right == null)
                    {
                        result += currentNode?._charData;
                        currentNode = _root;
                    }
                }

                return result;
            }
        }
    }
}