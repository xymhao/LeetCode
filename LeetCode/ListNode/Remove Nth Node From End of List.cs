namespace LeetCode.Objects
{
    public static class  Remove_Nth_Node_From_End_of_List
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

        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            ListNode root = new ListNode(0) {
                next = head
            };

            var curruntNode = head;
            while (true)
            {
                var nextNode = curruntNode.next;
                if (curruntNode == head && curruntNode.val == val)
                    root.next = curruntNode.next;
                if (nextNode == null)
                {
                    break;
                }
                if(nextNode.val == val)
                {
                    curruntNode.next = nextNode.next;
                    continue;
                }

                curruntNode = nextNode;
            }

            return root.next;
        }
    }
}
