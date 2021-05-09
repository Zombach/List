using List;
using NUnit.Framework;
using System;

namespace ListTests
{
    [TestFixture("ArrayList")]
    [TestFixture("LinkedList")]
    [TestFixture("DoubleLinkedList")]
    public class ListTest
    {
        IList actual;
        IList expected;
        string type = "";

        public ListTest(string name)
        {
            type = name;
        }

        public void SetupTwoMassive(int[] actualArray, int[] expectedArray)
        {
            switch (type)
            {
                case "ArrayList":
                    actual = new ArrayList(actualArray);
                    expected = new ArrayList(expectedArray);
                    break;
                case "LinkedList":
                    actual = new LinkedList(actualArray);
                    expected = new LinkedList(expectedArray);
                    break;
                case "DoubleLinkedList":
                    actual = new DoubleLinkedList(actualArray);
                    expected = new DoubleLinkedList(expectedArray);
                    break;
            }
        }

        public IList SetupOneMassive(int[] actualArray)
        {
            switch (type)
            {
                case "ArrayList":
                    actual = new ArrayList(actualArray);
                    break;
                case "LinkedList":
                    actual = new LinkedList(actualArray);
                    break;
                case "DoubleLinkedList":
                    actual = new DoubleLinkedList(actualArray);
                    break;
            }
            return actual;
        }



        #region Tests
        [TestCase(9, new[] { 5, 6, 6, 1 }, new[] { 5, 6, 6, 1, 9 })]
        [TestCase(68, new int[] { }, new[] { 68 })]
        [TestCase(-5, new[] { 5 }, new[] { 5, -5 })]
        // 1. Добавление значения в конец
        public void AddValueLastInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.AddValueLastInList(value);

            Assert.AreEqual(expected, actual);
        }        

        [TestCase(9, new[] { 5, 6, 6, 1 }, new[] { 9, 5, 6, 6, 1 })]
        [TestCase(68, new int[] { }, new[] { 68 })]
        [TestCase(-5, new[] { 5 }, new[] { -5, 5 })]
        // 2. Добавление значения в начало
        public void AddValueByFirstInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.AddValueByFirstInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, new[] { 5, 6, 6, 1 }, new[] { 5, 9, 6, 6, 1 }, 1)]
        [TestCase(68, new int[] { }, new[] { 68 }, 0)]
        [TestCase(-5, new[] { 5 }, new[] { -5, 5 }, 0)]
        // 3. Добавление значения по индексу
        public void AddValueByIndexInList_Tests(int value, int[] actualArray, int[] expectedArray, int index)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.AddValueByIndexInList(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 6, 1 }, new[] { 5, 6, 6, })]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9 })]
        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInList_Tests(int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.RemoveValueInEndInList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 6, 1 }, new[] { 6, 6, 1 })]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new[] { 5, 9, 0 }, new[] { 9, 0 })]
        // 5. Удаление из начала одного элемента
        public void RemoveValueInStartInList_Tests(int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.RemoveValueInStartInList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 5, 6, 7 }, 3)]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 0 }, 1)]
        // 6. Удаление по индексу одного элемента
        public void RemoveValueByIndexInList_Tests(int[] actualArray, int[] expectedArray, int index = 0)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.RemoveValueByIndexInList(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 5, 6 }, 2)]
        [TestCase(new[] { 1 }, new int[] { }, 1)]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9, 0 })]
        //7. Удаление из конца N элементов
        public void RemoveGivenQuantityOfValuesTheEndByList_Tests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.RemoveGivenQuantityOfValuesTheEndByList(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 7, 1 }, 2)]
        [TestCase(new[] { 1 }, new int[] { }, 1)]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9, 0 })]
        // 8. Удаление из начала N элементов
        public void RemoveGivenQuantityOfValuesTheStartByList_Tests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.RemoveGivenQuantityOfValuesTheStartByList(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 5, 6 }, 2, 2)]
        [TestCase(new[] { 1 }, new int[] { }, 0, 1)]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9, 0 })]
        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInList_Tests(int[] actualArray, int[] expectedArray, int index = 0, int count = 0)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.RemoveGivenQuantityOfValuesByIndexInList(index, count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, 1, 3)]
        [TestCase(new[] { 1 }, 1, 0)]
        [TestCase(new[] { 9, 9, 5, 0 }, 5, 2)]
        // 12. Первый индекс по значению
        public void GetFirstIndexByValueTests(int[] actualArray, int value, int expected)
        {
            IList list = SetupOneMassive(actualArray);
            int actual = list.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, 1, 3, new[] { 5, 3, 7, 1 })]
        [TestCase(new[] { 1 }, 0, 5, new[] { 5 })]
        [TestCase(new[] { 9, 9, 5, 0 }, 2, 2, new[] { 9, 9, 2, 0 })]
        // 13. Изменение по индексу
        public void ChangeValueByIndexTests(int[] actualArray, int index, int value, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.ChangeValueByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, new[] { 1, 7, 6 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 9, 9, 5, 0 }, new[] { 0, 5, 9, 9 })]
        // 14. Реверс (123 -> 321)
        public void ReversList_Tests(int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.ReversList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 7)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 9, 9, 5, 0 }, 9)]
        [TestCase(new[] { -9, -29, -5, 0 }, 0)]
        // 15. Поиск значения максимального элемента
        public void FindMaxValueByList_Tests(int[] actualArray, int expected)
        {
            IList list = SetupOneMassive(actualArray);
            int actual = list.FindMaxValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 1)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 9, 9, 5, 0 }, 0)]
        [TestCase(new[] { -9, -29, -5, 0 }, -29)]
        // 16. Поиск значения минимального элемента
        public void FindMinValueByList_Tests(int[] actualArray, int expected)
        {
            IList list = SetupOneMassive(actualArray);
            int actual = list.FindMinValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 1)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 9, 9, 5, 0 }, 0)]
        [TestCase(new[] { -9, -29, -5, 0 }, 3)]
        // 17. Поиск индекс максимального элемента
        public void FindIndexMaxValueByList_Tests(int[] actualArray, int expected)
        {
            IList list = SetupOneMassive(actualArray);
            int actual = list.FindIndexMaxValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 2)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 9, 9, 5, 0 }, 3)]
        [TestCase(new[] { -9, -29, -5, 0 }, 1)]
        // 18. Поиск индекс минимального элемента
        public void FindIndexMinValueByList_Tests(int[] actualArray, int expected)
        {
            IList list = SetupOneMassive(actualArray);
            int actual = list.FindIndexMinValueByList();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, new[] { 1, 6, 7 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 9, 9, 5, 0 }, new[] { 0, 5, 9, 9 })]
        [TestCase(new[] { -9, -29, -5, 0 }, new[] { -29, -9, -5, 0 })]
        // 19. Сортировка по возрастанию
        public void SortAscendingTests(int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.SortAscending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, new[] { 7, 6, 1 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 9, 9, 5, 0 }, new[] { 9, 9, 5, 0 })]
        [TestCase(new[] { -9, -29, -5, 0 }, new[] { 0, -5, -9, -29 })]
        // 20. Сортировка по убыванию
        public void SortDescendingTests(int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(actualArray, expectedArray);

            actual.SortDescending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new[] { 7, 3, 6, 7, 1 }, 0)]
        [TestCase(1, new[] { 1 }, 0)]
        [TestCase(0, new[] { 9, 9, 5, 0 }, 3)]
        // 21. Удаление по значению первого
        public void RemoveByValueFirstMatchInList_Tests(int value, int[] actualArray, int expected)
        {
            IList list = SetupOneMassive(actualArray);
            int actual = list.RemoveByValueFirstMatchInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new[] { 7, 3, 6, 7, 1 }, 2)]
        [TestCase(1, new[] { 1 }, 1)]
        [TestCase(9, new[] { 9, 9, 9, 9, 9, 9, 9, 5, 0 }, 7)]
        // 22. Удаление по значению всех(?вернуть кол-во)
        public void RemoveByValueAllMatchInList_Tests(int value, int[] actualArray, int expected)
        {
            IList list = SetupOneMassive(actualArray);

            int actual = list.RemoveByValueAllMatchInList(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 3, 6, 7, 1, 3, 6, 1 })]
        [TestCase(new int[] { }, new[] { 3, 6, 1 }, new[] { 3, 6, 1 })]
        [TestCase(new[] { 7, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 7, 1, 3, 6, 1, })]
        // 24. Добавление списка в конец
        public void AddNewListToEndList_Tests(int[] list, int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(list, expectedArray);

            actual.AddNewListToEndList(actualArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 1 }, new[] { 3, 6, 1, 7, 3, 6, 7, 1 })]
        [TestCase(new int[] { }, new[] { 3, 6, 1 }, new[] { 3, 6, 1 })]
        [TestCase(new[] { 7, 7, 1 }, new[] { 3, 6, 1 }, new[] { 3, 6, 1, 7, 7, 1 })]
        // 25. Добавление списка в начало
        public void AddNewListToBeginList_Tests(int[] list, int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(list, expectedArray);

            actual.AddNewListToBeginList(actualArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 3, 6, 3, 6, 1, 7, 1 })]
        [TestCase(0, new int[] { }, new[] { 3, 6, 1 }, new[] { 3, 6, 1 })]
        [TestCase(1, new[] { 7, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 3, 6, 1, 7, 1 })]
        // 26. Добавление списка по индексу
        public void AddNewListByIndexInList_Tests(int index, int[] list, int[] actualArray, int[] expectedArray)
        {
            SetupTwoMassive(list, expectedArray);
            actual.AddNewListByIndexInList(index, actualArray);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region NegativeTest

        // 3. Добавление значения по индексу
        [TestCase(new[] { 0, 4, -1, 5 }, 5, -1)]
        [TestCase(new[] { 1 }, -2, 2)]
        public void AddValueByIndexInList_ExceptionTests(int[] array, int value, int index)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddValueByIndexInList(index, value));
        }

        // 6. Удаление по индексу одного элемента
        [TestCase(new[] { 0, 4, -1, 5 }, -1)]
        [TestCase(new[] { 1 }, 2)]
        public void RemoveValueByIndexInList_ExceptionTests(int[] array, int index)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValueByIndexInList(index));
        }

        //7. Удаление из конца N элементов
        [TestCase(new[] { 0, 4, -1, 5 }, -4)]
        [TestCase(new[] { 1 }, -2)]
        [TestCase(new[] { 4, 5, 6, 1 }, 20)]
        [TestCase(new[] { 1, 5, 6 }, 99)]
        public void RemoveGivenQuantityOfValuesTheEndByList_ExceptionTests(int[] array, int count)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheEndByList(count));
        }

        // 8. Удаление из начала N элементов
        [TestCase(new[] { 0, 4, -1, 5 }, -1)]
        [TestCase(new int[] { }, -2)]
        [TestCase(new[] { 4, 5, 6, 1 }, 20)]
        [TestCase(new[] { 1, 5, 6 }, 99)]
        public void RemoveGivenQuantityOfValuesTheStartByList_ExceptionTests(int[] array, int count)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheStartByList(count));
        }

        // 9. Удаление по индексу N элементов
        [TestCase(new[] { 0, 4, -1, 5 }, 99)]
        [TestCase(new[] { 1 }, -2)]
        [TestCase(new[] { 4, 5, 6, 1 }, 20)]
        [TestCase(new[] { 1, 5, 6 }, 99)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_Index(int[] array, int index)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index));
        }
        // 9. Удаление по индексу N элементов
        [TestCase(new[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new[] { 1 }, 1, -2)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_Remove(int[] array, int index, int count)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index, count));
        }
        // 9. Удаление по индексу N элементов
        [TestCase(2, 9)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_ByZero(int index, int count)
        {
            actual = null;
            Assert.Throws<NullReferenceException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index, count));
        }

        // 13. Изменение по индексу
        [TestCase(new[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new[] { 1 }, -2, 2)]
        public void ChangeValueByIndex_ExceptionTests(int[] array, int index, int value)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.ChangeValueByIndex(index, value));
        }

        // 17. Поиск индекс максимального элемента     
        [TestCase(new int[] { })]
        public void FindIndexMaxValueByList_ExceptionTests(int[] array)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<NullReferenceException>(() => actual.FindIndexMaxValueByList());
        }

        // 18. Поиск индекс минимального элемента        
        [TestCase(new int[] { })]
        public void FindIndexMinValueByList_ExceptionTests(int[] array)
        {
            IList actual = SetupOneMassive(array);
            Assert.Throws<NullReferenceException>(() => actual.FindIndexMinValueByList());
        }

        // 26. Добавление списка по индексу        
        [TestCase(new[] { 0, 4, -1, 5 }, new[] { 79, 8 }, -11)]
        [TestCase(new[] { 1 }, new[] { 1 }, 99)]
        public void AddNewListByIndexInList_ExceptionTests(int[] array, int[] actualArray, int index)
        {
            IList actual = SetupOneMassive(array);  
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddNewListByIndexInList(index, actualArray));
        }
        #endregion

    }
}
