namespace Test.utils_HackerRank
{
    public class helperFunc_CheckCircleLinkedList
    {
        public class Node
        {
            public int data;
            public Node? next;
        }

        public class LinkList
        {
            public Node? head;

            public LinkList(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    this.Add(arr[i]);
                }
            }

            public void tranveresList(LinkList list)
            {
                Node? current = list.head;
                Console.Write(current?.data);

                while (current?.next != null)
                {
                    current = current.next;
                    Console.Write(" => " + current.data);
                }
            }

            public void Add(int data)
            {
                Node newNode = new Node();
                newNode.data = data;

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }

            public bool hasCirle(LinkList list)
            {
                Node? slow = head;
                Node? fast = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow?.next;
                    fast = fast.next.next;

                    if (slow == fast)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}