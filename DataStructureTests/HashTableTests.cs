using System.Collections;
using DataStructure.HashTableDemo;
using NUnit.Framework;

namespace DataStructureTests
{
    [TestFixture]
    public class HashTableTests
    {
        [Test]
        public void Should_Add_Key_Name_Value_Xu()
        {
            Demo();
            var hashTable = new MonHashTable(100, 1);
            var key = "Name";
            hashTable.Add(key, "Xu");
            hashTable.Add("1", "Xu1");
            hashTable.Add("2", "2");
            hashTable.Add("3", "3");
            hashTable.Add("4", "4");
            Assert.AreEqual("Xu", hashTable[key]);
            Assert.AreEqual("Xu1", hashTable["1"]);
            Assert.AreEqual("2", hashTable["2"]);
            Assert.AreEqual("3", hashTable["3"]);
            Assert.AreEqual("4", hashTable["4"]);
        }

        [Test]
        public void Should_Result_1_When_Add_Value_MoreThan_Default_Capacity()
        {
            //默认容量1
            var hashTable = new MonHashTable(1, 1);
            hashTable.Add(1,1);
            hashTable.Add(2,2);
            hashTable.Add(3,3);
            hashTable.Add(4,4);
            hashTable.Add(5,5);
            //验证数组扩容
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(i, hashTable[i]);
            }
        }
        
        

        private static void Demo()
        {
            var hashTable1 = new Hashtable
            {
                {"Name", "Xu"},
                {"Name1", "Xu"},
                {"Name2", "Xu"},
                {"Name3", "Xu"},
                {"Name4", "Xu"},
                {"Name5", "Xu"},
                {"Name6", "Xu"},
                {"Name7", "Xu"},
                {"8", "Xu"},
                {"9", "Xu"},
                {"10", "Xu"},
                {"11", "Xu"},
                {"12", "Xu"},
                {"14", "Xu"},
                {"22", "Xu"}
            };
        }
    }
}