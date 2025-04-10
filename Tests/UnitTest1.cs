using ClassLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly int[] _unsortedArray = { 5, 3, 8, 6, 2, 7, 4, 1 };
        private readonly int[] _sortedArray = { 1,2,3,4,5,6,7,8 };

        [TestMethod]
        public void BubbleSort_ShouldSortArray()
        {
            var result = Sorts.BubbleSort(_unsortedArray);
            CollectionAssert.AreEqual(_sortedArray, result);
        }

        [TestMethod]
        public void InsertionSort_ShouldSortList()
        {
            var unsortedList = new List<int>(_unsortedArray);
            var sortedList = new List<int>(_sortedArray);
            var result = Sorts.InsertionSort(unsortedList);
            CollectionAssert.AreEqual(sortedList, result);
        }

        [TestMethod]
        public void MergeSort_ShouldSortList()
        {
            var unsortedList = new List<int>(_unsortedArray);
            var sortedList = new List<int>(_sortedArray);
            var result = Sorts.MergeSort(unsortedList);
            CollectionAssert.AreEqual(sortedList, result);
        }

        [TestMethod]
        public void QuickSort_ShouldSortList()
        {
            var unsortedList = new List<int>(_unsortedArray);
            var sortedList = new List<int>(_sortedArray);
            Sorts.QuickSort(unsortedList, 0, unsortedList.Count - 1);
            CollectionAssert.AreEqual(sortedList, unsortedList);
        }

        [TestMethod]
        public void BucketSort_ShouldSortArray()
        {
            var result = Sorts.BucketSort((int[])_unsortedArray.Clone());
            CollectionAssert.AreEqual(_sortedArray, result);
        }

        [TestMethod]
        public void DutchFlagSort_ShouldSortDutchFlag()
        {
            var array = new int[] { 2, 0, 1, 2, 1, 0 };
            Sorts.DutchFlagSort(array);
            CollectionAssert.AreEqual(new int[] { 0, 0, 1, 1, 2, 2 }, array);
        }

        [TestMethod]
        public void HogwartsHat_ShouldSortHogwartsHouses()
        {
            var array = new int[] { 3, 1, 2, 0, 2, 3, 1, 0 };
            Sorts.HogwartsHat(array);
            CollectionAssert.AreEqual(new int[] { 0, 0, 1, 1, 2, 2, 3, 3 }, array);
        }
    }
}