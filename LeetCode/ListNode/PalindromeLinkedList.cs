using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            var flag = new ListNode(0) { next = head };
            var quick = flag;
            var slow = flag;
            while (quick?.next != null)
            {
                quick = quick.next.next;
                slow = slow.next;
            }

            //反转链表
            var cur = slow.next;
            ListNode pre = null;
            slow.next = null;
            slow = flag.next;

            //反转链表
            while (cur != null)
            {
                var temp = cur.next;//记录下一个系欸但
                cur.next = pre;//当前节点指向上一系欸但那

                pre = cur;//当前节点变为上一个节点
                cur = temp;//节点后移
            }

            while (pre != null)
            {
                if (pre.val != slow.val)
                {
                    return false;
                }

                pre = pre.next;
                slow = slow.next;
            }
            return true;
        }

        public static ListNode ReverseList(ListNode head)
        {
            //反转链表
            var cur = head;
            ListNode pre = null;

            while (cur != null)
            {
                var temp = cur.next;//记录下一个系欸但
                cur.next = pre;//当前节点指向上一系欸但那

                pre = cur;//当前节点变为上一个节点
                cur = temp;//节点后移
            }

            return pre;
        }
    }
}
