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
            var hashTable = new HashTable(100, 1);
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

        private static void Demo()
        {
            var hashTable1 = new Hashtable();
            hashTable1.Add("Name", "Xu");
            hashTable1.Add("Name1", "Xu");
            hashTable1.Add("Name2", "Xu");
            hashTable1.Add("Name3", "Xu");
            hashTable1.Add("Name4", "Xu");
            hashTable1.Add("Name5", "Xu");
            hashTable1.Add("Name6", "Xu");
            hashTable1.Add("Name7", "Xu");
            hashTable1.Add("8", "Xu");
            hashTable1.Add("9", "Xu");
            hashTable1.Add("10", "Xu");
            hashTable1.Add("11", "Xu");
            hashTable1.Add("12", "Xu");
            hashTable1.Add("14", "Xu");
            hashTable1.Add("22", "Xu");
        }
    }
}