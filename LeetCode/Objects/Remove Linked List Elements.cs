using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects
{
    public class Remove_Linked_List_Elements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode root = new ListNode(0);
            root.next = head;
        }
    }
}
