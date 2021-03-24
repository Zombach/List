using NUnit.Framework;
using List;

namespace ListTests
{
    public class ArrayListTests
    {
        [TestCase(9, new int[] { 5, 6, 6, 1 }, new int[] { 5, 6, 6, 1, 9 })]
        [TestCase(68, new int[] { }, new int[] { 68 })]
        [TestCase(-5, new int[] { 5 }, new int[] { 5, -5 })]
        public void AddValueLastInListTests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueLastInList(value);
            
            Assert.AreEqual(expected, actual);
        }
    
        [TestCase(9, new int[] { 5, 6, 6, 1 }, new int[] { 9, 5, 6, 6, 1 })]
        [TestCase(68, new int[] { }, new int[] { 68 })]
        [TestCase(-5, new int[] { 5 }, new int[] { -5, 5 })]
        public void AddValueByFirstInListTests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByFirstInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, new int[] { 5, 6, 6, 1 }, new int[] { 5, 9, 6, 6, 1 } , 1)]
        [TestCase(68, new int[] { }, new int[] { 68 })]
        [TestCase(-5, new int[] { 5 }, new int[] { -5, 5 })]
        public void AddValueByIndexInListTests(int value, int[] actualArray, int[] expectedArray, int index = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByIndexInList(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 6, 1 }, new int[] { 5, 6, 6, })]
        [TestCase(new int[] { 1}, new int[] { })]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9 })]
        public void RemoveValueInEndInListTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueInEndInList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 6, 1 }, new int[] { 6, 6, 1 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 9, 0 })]
        public void RemoveValueInStartInListTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueInStartInList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 5, 6, 7 }, 3)]
        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 0 }, 1)]
        public void RemoveValueByIndexInListTests(int[] actualArray, int[] expectedArray, int index = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueByIndexInList(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 5, 6 }, 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 1)]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9, 0 })]
        public void RemoveGivenQuantityOfValuesTheEndByListTests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesTheEndByList(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 7, 1 }, 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 1)]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9, 0 })]
        public void RemoveGivenQuantityOfValuesTheStartByListTests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesTheStartByList(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 5, 6 }, 2 , 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 0, 1)]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9, 0 })]
        public void RemoveGivenQuantityOfValuesByIndexInListTests(int[] actualArray, int[] expectedArray, int index = 0, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesByIndexInList(index, count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, 1, 3)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 9, 9, 5, 0 }, 5, 2)]
        public void GetFirstIndexByValueTests(int[] actualArray, int value, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, 1, 3, new int[] { 5, 3, 7, 1 })]
        [TestCase(new int[] { 1 }, 0, 5, new int[] { 5})]
        [TestCase(new int[] { 9, 9, 5, 0 }, 2, 2 , new int[] { 9, 9, 2, 0 })]
        public void ChangeValueByIndexTests(int[] actualArray, int index, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.ChangeValueByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, new int[] { 1, 7, 6 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 9, 5, 0 }, new int[] { 0, 5, 9, 9 })]
        public void ReversListTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.ReversList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, 7)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 9, 9, 5, 0 }, 9)]
        [TestCase(new int[] { -9, -29, -5, 0 }, 0)]
        public void FindMaxValueByListTests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindMaxValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, 1)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 9, 9, 5, 0 }, 0)]
        [TestCase(new int[] { -9, -29, -5, 0 }, -29)]
        public void FindMinValueByListTests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindMinValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, 1)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 9, 9, 5, 0 }, 0)]
        [TestCase(new int[] { -9, -29, -5, 0 }, 3)]
        public void FindIndexMaxValueByListTests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindIndexMaxValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, 2)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 9, 9, 5, 0 }, 3)]
        [TestCase(new int[] { -9, -29, -5, 0 }, 1)]
        public void FindIndexMinValueByListTests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindIndexMinValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, new int[] { 1, 6, 7 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 9, 5, 0 }, new int[] { 0, 5, 9, 9 })]
        [TestCase(new int[] { -9, -29, -5, 0 }, new int[] { -29, -9, -5, 0 })]
        public void SortAscendingTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.SortAscending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 1 }, new int[] { 7, 6, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 9, 5, 0 }, new int[] { 9, 9, 5, 0 })]
        [TestCase(new int[] { -9, -29, -5, 0 }, new int[] { 0, -5, -9, -29 })]
        public void SortDescendingTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.SortDescending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 7, 1 })]
        [TestCase(1, new int[] { 1 }, new int[] { })]
        [TestCase(0, new int[] { 9, 9, 5, 0 }, new int[] { 9, 9, 5 })]
        public void RemoveByValueFirstMatchInListTests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveByValueFirstMatchInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(1, new int[] { 1 }, new int[] { })]
        [TestCase(9, new int[] { 9, 9, 9, 9, 9, 9, 9, 5, 0 }, new int[] { 5 , 0 })]
        public void RemoveByValueAllMatchInListTests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveByValueAllMatchInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 3, 6, 7, 1, 3, 6, 1 })]
        [TestCase(new int[] {  }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(new int[] { 7, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 7, 1, 3, 6, 1, })]
        public void AddNewListToEndListTests(int[] _list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(_list);
            actual.AddNewListToEndList(actualArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1, 7, 3, 6, 7, 1})]
        [TestCase(new int[] { }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(new int[] { 7, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1, 7, 7, 1 })]
        public void AddNewListToBeginListTests(int[] _list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(_list);
            actual.AddNewListToBeginList(actualArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 3, 6, 3, 6, 1, 7, 1 })]
        [TestCase(0, new int[] { }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(1, new int[] { 7, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 3, 6, 1, 7, 1 })]
        public void AddNewListByIndexInListTests(int index, int[] _list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(_list);
            actual.AddNewListByIndexInList(index, actualArray);

            Assert.AreEqual(expected, actual);
        }



        //[TestCase(new int[] { })]        
        //public void ArrayList1Tests(int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList();

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(1, new int[] { 1 })]
        //public void ArrayList1Tests(int value, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(value);

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { 1, 5, 6, 7, 2 }, new int[] { 1, 5, 6, 7, 2 })]
        //public void ArrayList1Tests(int[] array, int[] expectedArray)
        //{
        //    ArrayList expected = new ArrayList(expectedArray);
        //    ArrayList actual = new ArrayList(array);

        //    Assert.AreEqual(expected, actual);
        //}
    }
}