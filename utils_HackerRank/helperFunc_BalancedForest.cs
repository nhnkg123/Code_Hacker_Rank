using System.Reflection.Emit;

namespace Test.utils_HackerRank
{
    public class helperFunc_BalancedForest
    {
        public class TreeNode_BalanceTree
        {
            public int _label;
            public int _value;
            public List<(int, int)> _children;
            public TreeNode_BalanceTree(int label, int value)
            {
                _label = label;
                _value = value;
                _children = new List<(int, int)>();
            }
        }

        public class Tree_BalanceForest
        {
            public TreeNode_BalanceTree? _root;

            public List<TreeNode_BalanceTree> _nodesList;
            public Tree_BalanceForest()
            {
                _nodesList = new List<TreeNode_BalanceTree>();
            }
            public Tree_BalanceForest(TreeNode_BalanceTree root)
            {
                _root = root;
                _nodesList = new List<TreeNode_BalanceTree>() { root };
            }

            public void AddEdge(TreeNode_BalanceTree source, int[] edge, int[] values)
            {
                int soureLabel = edge[0];
                int destinationLabel = edge[1];

                int sourceValue = values[soureLabel - 1];
                int desValue = values[destinationLabel - 1];

                //asume the source node exist
                TreeNode_BalanceTree desNode = new TreeNode_BalanceTree(destinationLabel, desValue);
                _nodesList.Add(desNode);
                desNode._children.Add((soureLabel, sourceValue));
                source._children.Add((destinationLabel, desValue));
            }

            public Tree_BalanceForest CutEdge(int[] edge)
            {
                Tree_BalanceForest treeResult = new Tree_BalanceForest();

                int sourceLabel = edge[0];
                int desLabel = edge[1];

                TreeNode_BalanceTree? sourceNode = _nodesList.Find(x => x._label == sourceLabel);
                TreeNode_BalanceTree? desNode = _nodesList.Find(x => x._label == desLabel);

                if (sourceNode != null)
                {
                    sourceNode._children = sourceNode?._children.Where(x => x.Item1 != desLabel).ToList();

                }
                if (desNode != null)
                {
                    desNode._children = desNode?._children.Where(x => x.Item1 != sourceLabel).ToList();
                }

                treeResult._root = desNode;

                return treeResult;
            }

            public int Balanced_Forest(int[][] edges)
            {
                int min = int.MaxValue;

                for (int i = 0; i < edges.Length; i++)
                {
                    for (int j = i + 1; j < edges.Length; j++)
                    {

                        // Tree_BalanceForest tempTree = deepClone();

                        Tree_BalanceForest cutTree1 = CutEdge(edges[i]);
                        Tree_BalanceForest cutTree2 = CutEdge(edges[j]);

                        int totalValTree1 = calTotalVal(cutTree1._root);
                        int totalValTree2 = calTotalVal(cutTree2._root);
                        int totalValTree3 = calTotalVal(this._root);

                        Console.WriteLine("test.............." + totalValTree1 + " " + totalValTree2 + " " + totalValTree3);

                        if (totalValTree1 == totalValTree2 && totalValTree3 - totalValTree1 < min)
                        {
                            min = totalValTree3 - totalValTree1;
                        }
                        else if (totalValTree1 == totalValTree3 && totalValTree2 - totalValTree1 < min)
                        {
                            min = totalValTree2 - totalValTree1;
                        }
                        else if (totalValTree2 == totalValTree3 && totalValTree1 - totalValTree2 < min)
                        {
                            min = totalValTree1 - totalValTree2;
                        }

                        // this._root = tempTree._root;
                        // this._nodesList = tempTree._nodesList;
                    }
                }

                Console.WriteLine("test min val......" + min);

                min = min == int.MaxValue ? -1 : min;

                return min;
            }

            public int calTotalVal(TreeNode_BalanceTree currentNode)
            {
                Queue<(int, int)> queue = new Queue<(int, int)>();
                List<int> visited = new List<int>();
                queue.Enqueue((currentNode._label, currentNode._value));
                int total = currentNode._value;

                while (queue.Count() > 0)
                {
                    (int currentLabel, int currentVal) = queue.Dequeue();

                    TreeNode_BalanceTree? currentNode2 = _nodesList.Find(x => x._label == currentLabel);
                    visited.Add(currentNode2._label);

                    foreach ((int labelChild, int ValChild) in currentNode2._children)
                    {
                        if (!visited.Contains(labelChild))
                        {
                            queue.Enqueue((labelChild, ValChild));
                            total += ValChild;
                        }
                    }

                }

                return total;
            }

            // public Tree_BalanceForest deepClone()
            // {
            //     Dictionary<int, TreeNode_BalanceTree> cloneNodeByLabel = new Dictionary<int, TreeNode_BalanceTree>();

            //     TreeNode_BalanceTree clonedRoot = CloneNodeRecursive(_root, cloneNodeByLabel);

            //     List<Node>
            // }

            // public TreeNode_BalanceTree CloneNodeRecursive(TreeNode_BalanceTree currentNode, Dictionary<int, TreeNode_BalanceTree> map)
            // {
            //     if (currentNode == null)
            //         return null;

            //     if (map.ContainsKey(currentNode._label))
            //     {
            //         return map[currentNode._label];
            //     }

            //     TreeNode_BalanceTree newCloneNode = new TreeNode_BalanceTree(currentNode._label, currentNode._value);

            //     map[currentNode._label] = newCloneNode;

            //     foreach ((int label, int value) in currentNode._children)
            //     {
            //         TreeNode_BalanceTree? childNode = _nodesList.Find(x => x._label == label);
            //         newCloneNode._children.Add((CloneNodeRecursive(childNode, map)._label, CloneNodeRecursive(childNode, map)._value));
            //     }

            //     return newCloneNode;
            // }

            public void TranverseTree()
            {
                Queue<(int, int)> queue = new Queue<(int, int)>();
                queue.Enqueue((_root._label, _root._value));
                List<(int, int)> tranverList = new List<(int, int)>();
                List<int> visited = new List<int>();

                while (queue.Count() > 0)
                {
                    (int label, int value) = queue.Dequeue();

                    TreeNode_BalanceTree? current = _nodesList.Find(x => x._label == label);
                    visited.Add(label);
                    tranverList.Add((label, value));

                    if (current != null)
                    {
                        foreach ((int childLabel, int childVal) in current._children)
                        {
                            if (!visited.Contains(childLabel))
                            {
                                queue.Enqueue((childLabel, childVal));
                            }
                        }
                    }
                }

                foreach (var item in tranverList)
                {
                    Console.Write($"({item.Item1},{item.Item2})" + " ");
                }
            }
        }
    }
}