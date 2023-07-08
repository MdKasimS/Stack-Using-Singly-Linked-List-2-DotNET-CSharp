namespace DSA
{
    public class SLLNode
    {
        private int data;
        private SLLNode? next;
        public SLLNode? Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }
        public SLLNode(int data) => Data = data;
    }
}