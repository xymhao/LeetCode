using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedList
    {
        public static LinkedNode GetLinkedList(int[] values)
        {
            var flag = new LinkedNode(0);
            if (values.Length  <=0 )
            {
                return null;
            }
            var curNode = new LinkedNode(values[0]);
            flag.Next = curNode;
            for (var index = 1; index < values.Length; index++)
            {
                int val = values[index];
                curNode.Next = new LinkedNode(val);
                curNode = curNode.Next;
            }

            return flag.Next;
        }
    }

    public class LinkedNode
    {
        public object Data { get; set; }

        public LinkedNode Next { get; set; }

        public LinkedNode(object data)
        {
            Data = data;
        }
    }
}
