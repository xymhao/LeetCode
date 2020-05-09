using System;
using System.Collections.Generic;
using System.Text;
using DataStructure;
using NUnit.Framework;

namespace DataStructureTests
{
    
    public class LinkedListTests
    {
        [Test]
        public void Should_Get_Link_List()
        {
            //todo 构造一个 1->2->3的链表并返回表头
            LinkedNode result = LinkedList.GetLinkedList(new[] {1, 2, 3, 4, 5});

            Assert.AreEqual(1,result.Data);
            Assert.AreEqual(2,result.Next.Data);
            Assert.AreEqual(3,result.Next.Next.Data);
            Assert.AreEqual(4, result.Next.Next.Next.Data);
            Assert.AreEqual(5, result.Next.Next.Next.Next.Data);

        }
    }
}
