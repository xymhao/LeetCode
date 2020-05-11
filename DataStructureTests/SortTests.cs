using DataStructure.BubbleSort;
using NUnit.Framework;

namespace DataStructureTests
{
    [TestFixture]
    public class SortTests
    {
        [Test]
        public void BubbleSortTests()
        {
            var array = new int[] { 4, 5, 6, 3, 2, 1 };
            Sort.BubbleSort(array);
            AssertSort(array);
        }

        [Test]
        public void InsertionSortTests()
        {
            var array = new int[] { 4, 5, 6, 3, 2, 1 };
            Sort.InsertionSort(array);
            AssertSort(array);
        }

        [Test]
        public void SelectSortTests()
        {
            var array = new int[] { 4, 5, 6, 3, 2, 1 };
            Sort.SelectSort(array);
            AssertSort(array);
        }

        [Test]
        public void MergeSortTests()
        {
            var array = new int[] { 4, 5, 6, 3, 2, 1 };
            Sort.MergeSor(array);
            AssertSort(array);
        }


        private static void AssertSort(int[] array)
        {
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(3, array[2]);
            Assert.AreEqual(4, array[3]);
            Assert.AreEqual(5, array[4]);
            Assert.AreEqual(6, array[5]);
        }
    }
}