using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects.Tests
{
    [TestClass()]
    public class Merge_Two_Sorted_ListsTests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };
            ListNode node1 = new ListNode(1)
            {
                next = new ListNode(5)
            };
            var ls = new Merge_Two_Sorted_Lists().MergeTwoLists(node,node1);
        }
    }
}