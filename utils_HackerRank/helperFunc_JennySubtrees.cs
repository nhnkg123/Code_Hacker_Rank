using System.Security.AccessControl;

namespace Test.utils_HackerRank
{
    public class helperFunc_JennySubtrees
    {
        public class Graph_Jenny
        {
            public List<List<int>> _GraphListStruct;
            public Graph_Jenny(int n)
            {
                _GraphListStruct = new List<List<int>>();
                for (int i = 0; i < n; i++)
                {
                    _GraphListStruct.Add(new List<int>());
                }
            }
            public void AddEdge(int[] edge)
            {
                int source = edge[0];
                int destination = edge[1];

                _GraphListStruct[source - 1].Add(destination);
                _GraphListStruct[destination - 1].Add(source);
            }
            public List<int> TranversGraph()
            {
                Queue<int> queue = new Queue<int>();
                List<int> visited = new List<int>();
                List<int> tranversList = new List<int>();
                queue.Enqueue(1);

                while (queue.Count() > 0)
                {
                    int current = queue.Dequeue();
                    tranversList.Add(current);
                    visited.Add(current);

                    foreach (int child in _GraphListStruct[current - 1])
                    {
                        if (!visited.Contains(child))
                        {
                            queue.Enqueue(child);
                        }
                    }
                }

                return tranversList;
            }
            public int JennySubtreesAlgorithm(int r)
            {
                HashSet<string> set = new HashSet<string>();

                for (int i = 0; i < _GraphListStruct.Count(); i++)
                {
                    string encodedTree = encodeTree(i, -1, r);
                    set.Add(encodedTree);
                }

                return set.Count();
            }

            public string encodeTree(int currentNode, int parent, int depth)
            {
                if (depth == 0)
                    return "()";

                List<string> listChild = new List<string>();

                foreach (int child in _GraphListStruct[currentNode])
                {
                    if (child != parent)
                        listChild.Add(encodeTree(child, currentNode, depth - 1));
                }

                return "(" + string.Join("", listChild) + ")";
            }
        }


    }
}