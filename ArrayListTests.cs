using NUnit.Framework;
using List;
using System;

namespace ListTests
{
    public class ArrayListTests
    {
        #region Tests
        [TestCase(9, new int[] { 5, 6, 6, 1 }, new int[] { 5, 6, 6, 1, 9 })]
        [TestCase(68, new int[] { }, new int[] { 68 })]
        [TestCase(-5, new int[] { 5 }, new int[] { 5, -5 })]
        // 1. ���������� �������� � �����
        public void AddValueLastInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueLastInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, new int[] { 5, 6, 6, 1 }, new int[] { 9, 5, 6, 6, 1 })]
        [TestCase(68, new int[] { }, new int[] { 68 })]
        [TestCase(-5, new int[] { 5 }, new int[] { -5, 5 })]
        // 2. ���������� �������� � ������
        public void AddValueByFirstInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByFirstInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, new int[] { 5, 6, 6, 1 }, new int[] { 5, 9, 6, 6, 1 }, 1)]
        [TestCase(68, new int[] { }, new int[] { 68 })]
        [TestCase(-5, new int[] { 5 }, new int[] { -5, 5 })]
        // 3. ���������� �������� �� �������
        public void AddValueByIndexInList_Tests(int value, int[] actualArray, int[] expectedArray, int index = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByIndexInList(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 6, 1 }, new int[] { 5, 6, 6, })]
        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9 })]
        // 4. �������� �� ����� ������ ��������
        public void RemoveValueInEndInList_Tests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueInEndInList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 6, 1 }, new int[] { 6, 6, 1 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 9, 0 })]
        // 5. �������� �� ������ ������ ��������
        public void RemoveValueInStartInList_Tests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueInStartInList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 5, 6, 7 }, 3)]
        [TestCase(new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 0 }, 1)]
        // 6. �������� �� ������� ������ ��������
        public void RemoveValueByIndexInList_Tests(int[] actualArray, int[] expectedArray, int index = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueByIndexInList(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 5, 6 }, 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 1)]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9, 0 })]
        //7. �������� �� ����� N ���������
        public void RemoveGivenQuantityOfValuesTheEndByList_Tests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesTheEndByList(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 7, 1 }, 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 1)]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9, 0 })]
        // 8. �������� �� ������ N ���������
        public void RemoveGivenQuantityOfValuesTheStartByList_Tests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesTheStartByList(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, new int[] { 5, 6 }, 2, 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 0, 1)]
        [TestCase(new int[] { 5, 9, 0 }, new int[] { 5, 9, 0 })]
        // 9. �������� �� ������� N ���������
        public void RemoveGivenQuantityOfValuesByIndexInList_Tests(int[] actualArray, int[] expectedArray, int index = 0, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesByIndexInList(index, count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, 1, 3)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 9, 9, 5, 0 }, 5, 2)]
        // 12. ������ ������ �� ��������
        public void GetFirstIndexByValueTests(int[] actualArray, int value, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 6, 7, 1 }, 1, 3, new int[] { 5, 3, 7, 1 })]
        [TestCase(new int[] { 1 }, 0, 5, new int[] { 5 })]
        [TestCase(new int[] { 9, 9, 5, 0 }, 2, 2, new int[] { 9, 9, 2, 0 })]
        // 13. ��������� �� �������
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
        // 14. ������ (123 -> 321)
        public void ReversList_Tests(int[] actualArray, int[] expectedArray)
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
        // 15. ����� �������� ������������� ��������
        public void FindMaxValueByList_Tests(int[] actualArray, int expectedArray)
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
        // 16. ����� �������� ������������ ��������
        public void FindMinValueByList_Tests(int[] actualArray, int expectedArray)
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
        // 17. ����� ������ ������������� ��������
        public void FindIndexMaxValueByList_Tests(int[] actualArray, int expectedArray)
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
        // 18. ����� ������ ������������ ��������
        public void FindIndexMinValueByList_Tests(int[] actualArray, int expectedArray)
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
        // 19. ���������� �� �����������
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
        // 20. ���������� �� ��������
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
        // 21. �������� �� �������� �������
        public void RemoveByValueFirstMatchInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveByValueFirstMatchInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 7, 3, 6, 7, 1 }, 2)]
        [TestCase(1, new int[] { 1 }, 1)]
        [TestCase(9, new int[] { 9, 9, 9, 9, 9, 9, 9, 5, 0 }, 7)]
        // 22. �������� �� �������� ����(?������� ���-��)
        public void RemoveByValueAllMatchInList_Tests(int value, int[] actualArray, int expected)
        {
            ArrayList list = new ArrayList(actualArray);
            int actual = list.RemoveByValueAllMatchInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 3, 6, 7, 1, 3, 6, 1 })]
        [TestCase(new int[] { }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(new int[] { 7, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 7, 1, 3, 6, 1, })]
        // 24. ���������� ������ � �����
        public void AddNewListToEndList_Tests(int[] _list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(_list);
            actual.AddNewListToEndList(actualArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1, 7, 3, 6, 7, 1 })]
        [TestCase(new int[] { }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(new int[] { 7, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1, 7, 7, 1 })]
        // 25. ���������� ������ � ������
        public void AddNewListToBeginList_Tests(int[] _list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(_list);
            actual.AddNewListToBeginList(actualArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 7, 3, 6, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 3, 6, 3, 6, 1, 7, 1 })]
        [TestCase(0, new int[] { }, new int[] { 3, 6, 1 }, new int[] { 3, 6, 1 })]
        [TestCase(1, new int[] { 7, 7, 1 }, new int[] { 3, 6, 1 }, new int[] { 7, 3, 6, 1, 7, 1 })]
        // 26. ���������� ������ �� �������
        public void AddNewListByIndexInList_Tests(int index, int[] _list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(_list);
            actual.AddNewListByIndexInList(index, actualArray);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region NegativeTest

        // 3. ���������� �������� �� �������
        [TestCase(new int[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new int[] { 1 }, -2, 2)]
        public void AddValueByIndexInList_ExceptionTests(int[] array, int value, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddValueByIndexInList(index, value));
        }

        // 6. �������� �� ������� ������ ��������
        [TestCase(new int[] { 0, 4, -1, 5 }, -1)]
        [TestCase(new int[] { 1 }, 2)]
        public void RemoveValueByIndexInList_ExceptionTests(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValueByIndexInList(index));
        }

        //7. �������� �� ����� N ���������
        [TestCase(new int[] { 0, 4, -1, 5 }, -4)]
        [TestCase(new int[] { 1 }, -2)]
        public void RemoveGivenQuantityOfValuesTheEndByList_ExceptionTests(int[] array, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheEndByList(count));
        }

        // 8. �������� �� ������ N ���������
        [TestCase(new int[] { 0, 4, -1, 5 }, -1)]
        [TestCase(new int[] {  }, -2)]
        public void RemoveGivenQuantityOfValuesTheStartByList_ExceptionTests(int[] array, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheStartByList(count));
        }

        // 9. �������� �� ������� N ���������
        [TestCase(new int[] { 0, 4, -1, 5 }, 99)]
        [TestCase(new int[] { 1 }, -2)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_Index(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index));
        }
        // 9. �������� �� ������� N ���������
        [TestCase(new int[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new int[] { 1 }, 1, -2)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_Remove(int[] array, int index, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index, count));
        }
        // 9. �������� �� ������� N ���������
        [TestCase(2, 9)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_ByZero(int index, int count)
        {
            ArrayList actual = null;
            Assert.Throws<NullReferenceException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index, count));
        }

        // 13. ��������� �� �������
        [TestCase(new int[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new int[] { 1 }, -2, 2)]
        public void ChangeValueByIndex_ExceptionTests(int[] array, int value, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.ChangeValueByIndex(index, value));
        }

        // 17. ����� ������ ������������� ��������     
        [TestCase(new int[] {  })]
        public void FindIndexMaxValueByList_ExceptionTests(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<NullReferenceException>(() => actual.FindIndexMaxValueByList());
        }

        // 18. ����� ������ ������������ ��������        
        [TestCase(new int[] { })]
        public void FindIndexMinValueByList_ExceptionTests(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<NullReferenceException>(() => actual.FindIndexMinValueByList());
        }

        // 26. ���������� ������ �� �������        
        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 79, 8 }, -11)]
        [TestCase(new int[] { 1 }, new int[] { 1 }, 99)]
        public void AddNewListByIndexInList_ExceptionTests(int[] array, int[] actualArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList addArray = new ArrayList(actualArray);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddNewListByIndexInList(index, actualArray));
        }
        #endregion
    }
}