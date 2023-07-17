namespace DSA
{
    public class SLLStack
    {
        public SinglyLinkedList stack;
        public SLLStack()
        {
            stack = new SinglyLinkedList();
        }

        public void Push(int data)
        {
            stack.AppendList(data);
        }
        public void Pop()
        {
            stack.DeletListNode(SinglyLinkedList.Count);
        }
        public void PrintStack()
        {
            if (stack.Head != null)
            {
                int tempCount = SinglyLinkedList.Count;
                string indicator = "";
                SLLNode? iterator;
                for (int i = 0; i < SinglyLinkedList.Count; ++i)
                {
                    iterator = stack.Head;
                    for (int j = tempCount; j > 1; --j)
                    {
                        iterator = iterator.Next;
                    }
                    if (tempCount == SinglyLinkedList.Count)
                    {
                        indicator = "<--- Top";
                    }

                    Console.WriteLine($"|{iterator.Data,6}| {indicator}");
                    Console.WriteLine("--------");
                    indicator = "";

                    --tempCount;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
        }
        public int Size()
        {
            return SinglyLinkedList.Count;
        }
        public string Peek()
        {
            if (SinglyLinkedList.Count > 0)
                return stack.Temp.Data.ToString();
            else
                return "[Stack Is Empty]";
        }
        public string IsEmpty()
        {
            if (SinglyLinkedList.Count == 0)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}