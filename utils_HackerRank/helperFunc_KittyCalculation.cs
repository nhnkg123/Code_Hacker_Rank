namespace Test.utils_HackerRank
{
    public class helperFunc_KittyCalculation
    {
        public List<double> KittyCalculation(
        int numOfpaths,
        int[][] edges,
        int numOfSets,
        int numOfSet1,
        int[] set1,
        int numOfSet2,
        int[] set2,
        int numOfSet3,
        int[] set3
    )
        {
            Graph treeOfPath = BuildGraph(numOfpaths, edges);

            // List<int> visited = new List<int>();
            // Console.WriteLine("test tranverse all nodes............");
            // treeOfPath.TranversAllNodes_RecursiveDFS(treeOfPath._NodesList[0]._label, visited);

            double result_set1 = handleSet(numOfSet1, set1, treeOfPath);
            double result_set2 = handleSet(numOfSet2, set2, treeOfPath);
            double result_set3 = handleSet(numOfSet3, set3, treeOfPath);

            return new List<double> { result_set1, result_set2, result_set3 };
        }

        public static Graph BuildGraph(int numOfPaths, int[][] edges)
        {
            int startingLabel = edges[0][0];
            List<int> adjacencyOfStarting = getListAdjacency(startingLabel, edges);

            NodeGraph starting = new NodeGraph(edges[0][0], adjacencyOfStarting);

            Graph graph = new Graph(starting);

            foreach (int[] edge in edges)
            {
                graph.AddEdge(edge);
            }

            return graph;
        }

        public static List<int> getListAdjacency(int label, int[][] edges)
        {
            List<int> listAdjacency = new List<int>();

            for (int i = 0; i < edges.Length; i++)
            {
                if (edges[i].Contains(label))
                {
                    listAdjacency.Add(edges[i][1]);
                }
            }

            return listAdjacency;
        }

        public class NodeGraph
        {
            public int _label;
            public List<int> _adjacencyNodes = new List<int>();

            public NodeGraph(int label, List<int> adjacencyNodes)
            {
                _label = label;
                _adjacencyNodes = adjacencyNodes;
            }
        }

        public class Graph
        {
            public List<NodeGraph> _NodesList = new List<NodeGraph>();

            public Graph(NodeGraph startingPoint)
            {
                _NodesList.Add(startingPoint);
            }

            public void TranversAllNodes()
            {
                Queue<int> queue = new Queue<int>() { };
                queue.Enqueue(_NodesList[0]._label);
                List<int> visited = new List<int>();


                while (queue.Count > 0)
                {
                    int currentNodeLabel = queue.Dequeue();

                    visited.Add(currentNodeLabel);

                    NodeGraph? currentNode = _NodesList.Find(x => x._label == currentNodeLabel);

                    if (currentNode != null)
                    {
                        EnqueueAdjacencyNodes(queue, currentNode, visited);
                    }
                }

                foreach (int item in visited)
                {
                    Console.Write(item + " ");
                }
            }

            public void TranversAllNodes_RecursiveDFS(int currentNodeLabel, List<int> visited)
            {
                if (visited.Contains(currentNodeLabel)) return;

                Console.Write(currentNodeLabel + " ");
                visited.Add(currentNodeLabel);

                NodeGraph? currentNode = _NodesList.Find(x => x._label == currentNodeLabel);

                if (currentNode != null)
                {
                    foreach (int child in currentNode._adjacencyNodes)
                    {
                        if (child != currentNode._label)
                        {
                            TranversAllNodes_RecursiveDFS(child, visited);
                        }
                    }
                }
            }

            public void AddEdge(int[] edge)
            {
                int sourceLabel = edge[0];
                int destinationLabel = edge[1];

                NodeGraph? existingDestination = _NodesList.Find(x => x._label == destinationLabel);

                if (existingDestination == null)
                {
                    NodeGraph destinationNode = new NodeGraph(destinationLabel, new List<int> { sourceLabel });
                    _NodesList.Add(destinationNode);

                    foreach (NodeGraph node in _NodesList)
                    {
                        if (node._label == sourceLabel && !node._adjacencyNodes.Contains(destinationLabel))
                        {
                            node._adjacencyNodes.Add(destinationLabel);
                        }
                    }
                }
                else
                {
                    foreach (NodeGraph node in _NodesList)
                    {
                        if (node._label == destinationLabel && !node._adjacencyNodes.Contains(sourceLabel))
                        {
                            node._adjacencyNodes.Add(sourceLabel);
                        }
                    }

                    foreach (NodeGraph node in _NodesList)
                    {
                        if (node._label == sourceLabel && !node._adjacencyNodes.Contains(destinationLabel))
                        {
                            node._adjacencyNodes.Add(destinationLabel);
                        }
                    }
                }
            }

            public void FindNode(int label)
            {
                // Queue<int> queue = new Queue<int>();
                // List<int> visited = new List<int>();

                // NodeGraph? currentNode = _statingPoint;

                // while (!isEndNode(currentNode, visited) && currentNode._label != label)
                // {
                //     EnqueueAdjacencyNodes(queue, currentNode, visited);
                //     visited.Add(currentNode._label);

                //     currentNode = new NodeGraph(queue.Dequeue(), new List<int> { queue.Dequeue() });
                // }

                // return currentNode;
            }
        }

        public static void EnqueueAdjacencyNodes(Queue<int> queue, NodeGraph? currentNode, List<int> visited)
        {
            foreach (int item in currentNode._adjacencyNodes)
            {
                if (!visited.Contains(item))
                {
                    queue.Enqueue(item);
                }
            }
        }

        public static double handleSet(int numOfSet, int[] sets, Graph graph)
        {
            int result = 0;

            if (sets.Length == 1) return 0;

            int sum = 0;

            for (int i = 0; i < sets.Length; i++)
            {
                for (int j = i; j < sets.Length; j++)
                {
                    if (i != j)
                    {
                        sum += sets[i] * sets[j] * calDistance_DFS_nenBFS(sets[i], sets[j], graph);
                    }
                }
            }

            return sum % (Math.Pow(10, 9) + 7);
        }

        public static int calDistance_DFS_nenBFS(int point1, int point2, Graph graph)
        {
            int minDistance = int.MaxValue;

            Stack<(int, int)> stack = new Stack<(int, int)>();
            List<int> visited = new List<int>();

            stack.Push((point1, 0));

            while (stack.Count() > 0)
            {
                // Console.WriteLine("check stack.....: ");
                // foreach (var (current, dis) in stack)
                // {
                //     Console.Write($"({current}, {dis})" + " ");
                // }
                // Console.WriteLine();

                var (currentNode, distance) = stack.Pop();

                visited.Add(currentNode);

                NodeGraph? node1 = graph._NodesList.Find(x => x._label == currentNode);

                PushAdjactionNodes(stack, node1, visited, distance + 1);

                if (node1._label == point2 && distance < minDistance)
                {
                    minDistance = distance;
                }
            }

            return minDistance;
        }

        public static void PushAdjactionNodes(Stack<(int, int)> stack, NodeGraph node1, List<int> visited, int distance)
        {
            foreach (int adjacencyNode in node1._adjacencyNodes)
            {
                if (!visited.Contains(adjacencyNode))
                {
                    stack.Push((adjacencyNode, distance));
                }
            }
        }
    }
}