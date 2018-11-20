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
    public class Remove_Nth_Node_From_End_of_ListTests
    {
        [TestMethod()]
        public void RemoveNthFromEndTest()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(2) {
                    next = new ListNode(3) {
                        next = new ListNode (4)
                    }
                }
            };
            ListNode node1 = new ListNode(1) {
                next = new ListNode (2)
            };
            //Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(node1, 1);
            Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(node1, 2);

            Assert.Fail();
        }
    }
}