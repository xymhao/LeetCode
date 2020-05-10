using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class PalindromeLinkedListTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };
            var result = PalindromeLinkedList.IsPalindrome(node);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void Should_Is_False()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(1)
                    }
                }
            };
            var result = PalindromeLinkedList.IsPalindrome(node);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ReverseListTest()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(1)
                    }
                }
            };



            var result = PalindromeLinkedList.ReverseList(node);
            var str = "";
            while (result != null)
            {
                str += result.val.ToString();
                result = result.next;
            }
            Assert.AreEqual("1121", str);


        }

        [TestMethod()]
        public void MergeKListsTest()
        {
            ListNode[] listNodes = new[]
            {
                new ListNode(1)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                    }
                },
                new ListNode(1)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                },
                new ListNode(2)
                {
                    next = new ListNode(6)
                }
            };
            var result = PalindromeLinkedList.MergeKLists(listNodes);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.next.val);
            Assert.AreEqual(5, result.next.next.next.next.next.next.val);
            Assert.AreEqual(6, result.next.next.next.next.next.next.next.val);

        }
    }
}