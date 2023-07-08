namespace DSA
{
    public class SinglyLinkedList
    {
        private static int count = 0;
        private SLLNode? temp;
        private SLLNode? head;
        public SLLNode? Temp { get => temp; set => temp = value; }
        public SLLNode? Head { get => head; set => head = value; }
        public static int Count { get => count; set => count = value; }
        public SinglyLinkedList()
        {
            Head = null;
            Temp = null;
        }
        public void AppendList(int data)
        {
            if (Head == null)
            {
                Head = new SLLNode(data);
                Temp = Head;
                ++Count;
            }
            else
            {
                Temp.Next = new SLLNode(data);
                Temp = Temp.Next;
                ++Count;
            }
        }
        public void DisplayList()
        {
            if (Head != null)
            {
                SLLNode? iterator = this.Head;
                for (int i = 0; i < Count; ++i)
                {
                    Console.Write($"{iterator.Data}-");
                    iterator = iterator.Next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List Is Empty");
            }
        }
        public void PrependList(int data)
        {
            if (Head == null)
            {
                Head = new SLLNode(data);
                Temp = head;
                ++Count;
            }
            else
            {
                SLLNode oldHead = Head;
                Head = new SLLNode(data);
                Head.Next = oldHead;
                ++Count;
            }
        }
        public void InsertInList(int data, int pos)
        {
            SLLNode iterator = Head;
            SLLNode temp;
            if (pos <= Count + 1 || pos == 1)
            {
                if (Head != null)
                {
                    if (pos == 1)
                    {
                        PrependList(data);
                    }
                    else if (pos == Count + 1)
                    {
                        AppendList(data);
                    }
                    else
                    {
                        for (int i = 1; i < pos - 1; ++i)
                        {
                            // Console.Write($"{i}.{iterator.Data} - ");
                            // Console.ReadKey();
                            iterator = iterator.Next;
                        }
                        temp = iterator.Next;
                        iterator.Next = new SLLNode(data);
                        iterator = iterator.Next;
                        iterator.Next = temp;
                        ++Count;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Position");
            }
        }
        public void RotateForward(int pos)
        {
            if (pos < count)
            {
                for (int i = 0; i < pos; ++i)
                {
                    if (Head == null || Count == 1)
                    {
                        return;
                    }

                    SLLNode temp = Head;
                    SLLNode tempTail = null;

                    while (temp.Next != null)
                    {
                        tempTail = temp;
                        temp = temp.Next;
                    }

                    tempTail.Next = null;
                    temp.Next = Head;
                    Head = temp;
                    Temp = tempTail;
                }
            }
        }
        public void RotateBackward(int pos)
        {
            if (pos < Count)
            {
                for (int i = 0; i < pos; ++i)
                {
                    if (Head == null || Count == 1)
                    {
                        return;
                    }
                    SLLNode temp = Head;
                    while (temp.Next != null)
                    {
                        if (Head == null || Count == 1)
                        {
                            return;
                        }
                        temp = temp.Next;
                    }
                    temp.Next = Head;
                    temp = Head;
                    Head = Head.Next;
                    temp.Next = null;
                    Temp = temp;
                }
            }
        }
        public void DeletListNode(int pos)
        {
            if (Head != null && pos <= Count)
            {
                SLLNode temp = Head;

                if (pos == 1)
                {
                    Head = Head.Next;
                    --Count;
                    return;
                }
                else if (pos == Count)
                {
                    for (int i = 0; i < pos - 2; ++i)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = null;
                    --Count;
                    Temp = temp;
                }
                else
                {
                    for (int i = 0; i < pos - 2; ++i)
                    {
                        // Console.Write($"{i}.{temp.Data} - ");
                        // Console.ReadKey();
                        temp = temp.Next;
                    }
                    if (temp.Next.Next != null)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    else
                    {
                        temp.Next = null;
                        Temp = temp;
                    }
                    --Count;
                }
            }
            else
            {
                Console.WriteLine("Out Of Bound");
            }
        }
        public void UpdateNode(int data, int pos)
        {
            if (Head != null)
            {
                SLLNode temp = Head;
                if (pos <= Count)
                {

                    for (int i = 0; i < pos - 1; ++i)
                    {
                        // Console.Write($"{i + 1}. {temp.Data}");
                        Console.ReadKey();
                        temp = temp.Next;
                    }
                    temp.Data = data;
                    Console.WriteLine("Data updated successfully.....");
                }
                else
                {
                    Console.WriteLine("List is out of bound");
                }
            }
            else
            {
                Console.WriteLine("List Is Empty");
                Console.ReadKey();
            }
        }
    }
}