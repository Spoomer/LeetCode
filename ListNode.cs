namespace LeetCode
{
    public class ListNode<T>
    {
        public T val;
        public ListNode<T> next;
        public ListNode(T val = default(T), ListNode<T> next = null)
        {
            this.val = val;
            this.next = next;
        }
        
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode(int[] digits)
        {
            ListNode currentNode = this;
            for (int i = 0; i < digits.Length-1; i++)
            {
                currentNode.val = digits[i];
                currentNode.next = new ListNode();
                currentNode = currentNode.next;
            }
            currentNode.val = digits[digits.Length - 1];
        }
    }

}
