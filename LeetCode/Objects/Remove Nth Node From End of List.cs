namespace LeetCode.Objects
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static class Remove_Nth_Node_From_End_of_List
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode root = new ListNode(0)
            {
                next = head
            };

            var curruntNode = head;
            var lastNode = head;
            int index = 0;
            while (true)
            {
                int x = 1;
                ListNode nNode = curruntNode;
                while (x < n)
                {
                    nNode = nNode.next;
                    x++;
                }
                if (nNode == null)
                {
                    root.next = curruntNode.next;
                    break;
                }
                if (nNode.next == null)
                {
                    if (lastNode == curruntNode)
                    {
                        root.next = curruntNode.next;
                    }
                    else
                    {
                        lastNode.next = index == 0 ? null : curruntNode.next;
                    }
                    break;
                }
                else
                {
                    if (index >= 1)
                    {
                        lastNode = lastNode.next;
                    }
                    curruntNode = curruntNode.next;
                }

                index++;
            }
            return root.next;
        }
    }
}
