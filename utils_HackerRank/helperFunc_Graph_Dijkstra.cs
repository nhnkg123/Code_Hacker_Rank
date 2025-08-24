using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Test.utils_HackerRank
{
    public class helperFunc_Graph_Dijkstra
    {
        public void RunDijkstraAl(
        int numOfpaths,
        int[][] edges
    )
        {
            Graph treeOfPath = BuildGraph(numOfpaths, edges);

            List<int> visited = new List<int>();
            Console.WriteLine("test tranverse all nodes............");
            treeOfPath.TranversAllNodes_RecursiveDFS(treeOfPath._NodesList[0]._label, visited);

            // List<(int, int)> shortestPath = new List<(int, int)> { (0, 0) };
            List<int> visited2 = new List<int>();
            List<(int, int)> shortestPath = treeOfPath.ShortestPath_Dijkstra_PriorityQueueUsingArray(0, 2);


            Console.WriteLine("child of 3:.............");
            foreach (var child in treeOfPath._NodesList.Find(x => x._label == 3)._adjacencyNodes)
            {
                var (label, weight) = child;
                Console.Write($"{label},{weight}" + " ");
            }
            Console.WriteLine();



            Console.WriteLine("test shortedPath Dijkstra............");
            foreach (var node in shortestPath)
            {
                var (label, weight) = node;
                Console.Write($"({label}, {weight})" + " ");
            }

            // return new List<int>();
        }

        public static Graph BuildGraph(int numOfPaths, int[][] edges)
        {
            Graph graph = new Graph(5);

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
            public List<(int, int)> _adjacencyNodes = new List<(int, int)>();

            public NodeGraph(int label, List<(int, int)> adjacencyNodes)
            {
                _label = label;
                _adjacencyNodes = adjacencyNodes;
            }
        }

        public class Graph
        {
            public int _vertices;
            public List<NodeGraph> _NodesList = new List<NodeGraph>();

            public Graph(int vertices)
            {
                _vertices = vertices;

                for (int i = 0; i < vertices; i++)
                {
                    NodeGraph newNode = new NodeGraph(i, new List<(int, int)>());
                    _NodesList.Add(newNode);
                }
            }

            // public void TranversAllNodes()
            // {
            //     Queue<int> queue = new Queue<int>() { };
            //     queue.Enqueue(_NodesList[0]._label);
            //     List<int> visited = new List<int>();


            //     while (queue.Count > 0)
            //     {
            //         int currentNodeLabel = queue.Dequeue();

            //         visited.Add(currentNodeLabel);

            //         NodeGraph? currentNode = _NodesList.Find(x => x._label == currentNodeLabel);

            //         if (currentNode != null)
            //         {
            //             EnqueueAdjacencyNodes(queue, currentNode, visited);
            //         }
            //     }

            //     foreach (int item in visited)
            //     {
            //         Console.Write(item + " ");
            //     }
            // }

            public void TranversAllNodes_RecursiveDFS(int currentNodeLabel, List<int> visited)
            {
                if (visited.Contains(currentNodeLabel)) return;

                Console.Write(currentNodeLabel + " ");

                visited.Add(currentNodeLabel);

                NodeGraph? currentNode = _NodesList.Find(x => x._label == currentNodeLabel);

                if (currentNode != null)
                {
                    foreach (var child in currentNode._adjacencyNodes)
                    {
                        (int labelChild, int weight) = child;
                        if (labelChild != currentNode._label)
                        {
                            TranversAllNodes_RecursiveDFS(labelChild, visited);
                        }
                    }
                }
            }

            public void AddEdge(int[] edge)
            {
                int sourceLabel = edge[0];
                int destinationLabel = edge[1];
                int weight = edge[2];

                var currentDestination = (destinationLabel, weight);
                if (!_NodesList[sourceLabel]._adjacencyNodes.Contains(currentDestination))
                {
                    _NodesList[sourceLabel]._adjacencyNodes.Add(currentDestination);
                }

                var currentSource = (sourceLabel, weight);
                if (!_NodesList[destinationLabel]._adjacencyNodes.Contains(currentSource))
                {
                    _NodesList[destinationLabel]._adjacencyNodes.Add(currentSource);
                }

            }

            public void ShortestPath_Dijkstra_Recursive(int currentLabel, int destination, List<(int, int)> ShorttestPath, List<int> visited)
            {
                (int? label2, int? distance) = ShorttestPath.Find(x => x.Item1 == currentLabel);
                int currentDistance = distance ?? 0;

                int currentLabelShorted = 0;
                int shortestDistance = int.MaxValue;

                visited.Add(currentLabel);

                NodeGraph? currentNode = _NodesList.Find(x => x._label == currentLabel);

                // Console.Write("currentLabel.........." + currentNode._label);

                if (currentNode != null)
                {
                    foreach (var child in currentNode._adjacencyNodes)
                    {
                        var (label, weight) = child;
                        if (!visited.Contains(label) && currentDistance + weight < shortestDistance)
                        {
                            shortestDistance = currentDistance + weight;
                            currentLabelShorted = label;
                        }
                    }
                }
                Console.Write("shortestDistance.........." + shortestDistance);

                ShorttestPath.Add((currentLabelShorted, shortestDistance));

                if (currentLabelShorted == destination) return;

                if (!visited.Contains(currentLabelShorted))
                {
                    ShortestPath_Dijkstra_Recursive(currentLabelShorted, destination, ShorttestPath, visited);
                }
            }

            public List<(int, int)> ShortestPath_Dijkstra_PriorityQueueUsingArray(int currentLabel, int destination)
            {
                PriorityQueueArray priorQueue = new PriorityQueueArray(5);

                List<(int, int)> ShortestPathREsult = new List<(int, int)>();

                int[] distances = new int[_vertices];

                for (int i = 0; i < _vertices; i++)
                {
                    distances[i] = int.MaxValue;
                }

                priorQueue.Enqueue(currentLabel, 0);

                List<int> visited = new List<int>();

                while (priorQueue.isEmpty() == false)
                {
                    (int dequeueLabel, int dequeueweight) = priorQueue.Dequeue();

                    visited.Add(currentLabel);
                    ShortestPathREsult.Add((dequeueLabel, dequeueweight));


                    foreach (var child in _NodesList[dequeueLabel]._adjacencyNodes)
                    {
                        var (label, weight) = child;
                        if (!visited.Contains(label) && dequeueweight + weight < distances[label])
                        {
                            distances[label] = dequeueweight + weight;
                            priorQueue.Enqueue(label, dequeueweight + weight);
                        }
                    }

                    // for (int i = 0; i < priorQueue._queue.Count(); i++)
                    // {
                    //     var (label, weight) = priorQueue._queue[i];
                    //     Console.Write($"({label},{weight})" + " ");
                    // }

                    // Console.WriteLine("label............." + dequeueLabel);
                    // Console.WriteLine("weight............." + dequeueweight);
                }

                return ShortestPathREsult;
            }
        }

        public class PriorityQueueArray
        {
            public int _vertices;
            public List<(int, int)> _queue;

            public PriorityQueueArray(int vertices)
            {
                _vertices = vertices;
                _queue = new List<(int, int)>();
            }

            public void Enqueue(int label, int distance)
            {
                int index = _queue.FindIndex(x => x.Item1 == label);

                if (index != -1)
                {
                    if (_queue[index].Item2 > distance)
                    {
                        _queue[index] = (label, distance);
                    }
                }
                else
                {
                    _queue.Add((label, distance));
                }

            }

            public (int, int) Dequeue()
            {
                // if (_queue.Count == 0)
                //     return (-1, -1);

                (int label, int weight) = _queue[0];

                int minDistance = weight;
                int minIndex = 0;

                for (int i = 1; i < _queue.Count(); i++)
                {
                    if (_queue[i].Item2 < minDistance)
                    {
                        minDistance = _queue[i].Item2;
                        minIndex = i;
                    }
                }

                var result = _queue[minIndex];
                _queue.RemoveAt(minIndex);

                return result;
            }

            public bool isEmpty()
            {
                return _queue.Count() == 0;
            }
        }

        public static int findIndex(int[] priorityArr, int value)
        {
            int result = 0;

            for (int i = 0; i < priorityArr.Length; i++)
            {
                if (priorityArr[i] == value)
                {
                    result = i;
                }
            }

            return result;
        }

        // public static void EnqueueAdjacencyNodes(Queue<int> queue, NodeGraph? currentNode, List<int> visited)
        // {
        //     foreach (int item in currentNode._adjacencyNodes)
        //     {
        //         if (!visited.Contains(item))
        //         {
        //             queue.Enqueue(item);
        //         }
        //     }
        // }
    }
}