using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class SwapPairsTest
    {
        [TestMethod]
        public void Should_Result_Swap()
        {
            var listNode = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            val = 4,
                        }
                    }
                }
            };
            var node = SwapPairs(listNode);
            Assert.AreEqual(2, node.val);
            Assert.AreEqual(1, node.next.val);
            Assert.AreEqual(4, node.next.next.val);
            Assert.AreEqual(3, node.next.next.next.val);
            Assert.IsNull(node.next.next.next.next);
        }
        public ListNode SwapPairs2(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var result = new ListNode();
            result.next = head.next;

            ListNode lastNode = null;
            var currentNode = head;
            while (currentNode?.next != null)
            {
                var node1 = currentNode;
                var node2 = currentNode.next;
                //交换
                var node2Next = node2.next;
                node1.next = node2Next;
                node2.next = node1;

                if (lastNode != null)
                {
                    lastNode.next = node2;
                }
                lastNode = node1;
                currentNode = currentNode.next;
            }

            return result.next;
        }
        
        public ListNode SwapPairs(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var result = head.next;
            head.next = SwapPairs2(result.next);
            result.next = head;
            return result;
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
        }
    }

}

