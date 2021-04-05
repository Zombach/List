using NUnit.Framework;
using List;

namespace ListTests
{
    class LinkedListTests
    {
        // 1. Добавление значения в конец
        [TestCase(new int[] { 0, 4, -1, 5 }, 9, new int[] { 0, 4, -1, 5, 9 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 5, 1, -10, 3 })]
        public void AddValueLastInLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueLastInList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 2. Добавление значения в начало
        [TestCase(new int[] { 0, 4, -1, 5 }, 7, new int[] { 7, 0, 4, -1, 5 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 3, 5, 1, -10 })]
        public void AddValueByFirstInLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByFirstInList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 3. Добавление значения по индексу
        [TestCase(new int[] { 0, 4, -1, 5 }, 9, 2, new int[] { 0, 4, 9, -1, 5 })]
        [TestCase(new int[] { }, 5, 0, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 0, 3, new int[] { 5, 1, -10, 0 })]
        public void AddValueByIndexInLinkedListTests(int[] list, int value, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByIndexInList(value, index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 4. Удаление из конца одного элемента
        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 0, 4, -1 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, new int[] { 5, 1 })]
        public void RemoveValueInEndInLinkedListTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveValueInEndInList();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 5. Удаление из начала одного элемента
        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 4, -1, 5 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, new int[] { 1, -10 })]
        public void RemoveValueInStartInLinkedListTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveValueInStartInList();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 6. Удаление по индексу одного элемента
        [TestCase(new int[] { 0, 4, -1, 5 }, 2, new int[] { 0, 4, 5 })]
        [TestCase(new int[] { 5 }, 0, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, 2, new int[] { 5, 1 })]
        public void RemoveValueByIndexInLinkedListTests(int[] list, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveValueByIndexInList(index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 7. Удаление из конца N элементов
        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 6, new int[] { 0, 4, 9 })]
        [TestCase(new int[] { 5 }, 1, new int[] { })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, new int[] { 5, 1, -10 })]
        public void RemoveGivenQuantityOfValuesTheEndByLinkedListTests(int[] list, int qty, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveGivenQuantityOfValuesTheEndByList(qty);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 8. Удаление из начала N элементов
        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 6, new int[] { 8, -1, 5 })]
        [TestCase(new int[] { 5 }, 1, new int[] { })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, new int[] { 1, -10, 5 })]
        public void RemoveGivenQuantityOfValuesTheStartByLinkedListTests(int[] list, int qty, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveGivenQuantityOfValuesTheStartByList(qty);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 9. Удаление по индексу N элементов
        [TestCase(new int[] { 0, 4, 9, 0 }, 1, 1, new int[] { 0, 9, 0 })]
        [TestCase(new int[] { 5 }, 0, 0, new int[] { 5 })]
        [TestCase(new int[] { }, 0, 0, new int[] { })]
        [TestCase(new int[] { 3, 4, 2, 8, 1, 7 }, 0, 3, new int[] { 4, 2, 8, 1, 7 })]
        [TestCase(new int[] { 3, 4, 5, 4, 4, 2, 8, 1, 7 }, 3, 5, new int[] { 3, 4, 5, 7 })]
        public void RemoveGivenQuantityOfValuesByIndexInLinkedListTests(int[] list, int index, int qty, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveGivenQuantityOfValuesByIndexInList(index, qty);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 12. Первый индекс по значению
        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 8, 4)]
        [TestCase(new int[] { 5 }, 5, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, 1)]
        public void GetFirstIndexByValueTests(int[] list, int value, int  expected)
        {
            LinkedList array = new LinkedList(list);
            int actual = array.GetFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        // 13. Изменение по индексу
        [TestCase(new int[] { 0, 4, 9, 0 }, 3, 45, new int[] { 0, 4, 9, 45 })]
        [TestCase(new int[] { 5 }, 0, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, 7, new int[] { 5, 7, -10, 5 })]
        public void ChangeValueByIndexTests(int[] list, int index, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.ChangeValueByIndex(index, value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 14. Реверс (123 -> 321)
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 9, 4, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 3 }, new int[] { 3, 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 5, -10, 1, 5 })]
        public void ReversLinkedListTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.ReversList();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }    

        // 15. Поиск значения максимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 9)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 5)]
        [TestCase(new int[] { 5, 1, -10, 20 }, 20)]
        public void FindMaxValueByLinkedListTests(int[] list, int expected)
        {
            LinkedList array = new LinkedList(list);
            int actual = array.FindMaxValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 16. Поиск значения минимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 0)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 5, 1, -10, 5 }, -10)]
        [TestCase(new int[] { 5, 1, -10, -20 }, -20)]
        public void FindMinValueByLinkedListTests(int[] list, int expected)
        {
            LinkedList array = new LinkedList(list);
            int actual = array.FindMinValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 17. Поиск индекс максимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 2)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 0)]
        [TestCase(new int[] { 5, 1, -10, 20 }, 3)]
        public void FindIndexMaxValueByLinkedListTests(int[] list, int expected)
        {
            LinkedList array = new LinkedList(list);
            int actual = array.FindIndexMaxValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 18. Поиск индекс минимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 0)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 2)]
        [TestCase(new int[] { 5, 1, -10, -20 }, 3)]
        public void FindIndexMinValueByLinkedListTests(int[] list, int expected)
        {
            LinkedList array = new LinkedList(list);
            int actual = array.FindIndexMinValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 19. Сортировка по возрастанию
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 0, 4, 9 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 3, 4, 2, 8, 1, 7 }, new int[] { 1, 2, 3, 4, 7, 8 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 4, 4, 4, 5, 5, 6, 6, 7, 8 })]
        public void SortAscendingTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.SortAscending();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 20. Сортировка по убыванию
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 9, 4, 0, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 3, 4, 2, 8, 1, 7 }, new int[] { 8, 7, 4, 3, 2, 1 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, new int[] { 8, 7, 6, 6, 5, 5, 4, 4, 4, 3, 2, 2, 2, 1, 1, 1, 1 })]
        public void SortDescendingTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.SortDescending();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 21. Удаление по значению первого
        [TestCase(new int[] { 0, 4, 9, 0 }, 4, new int[] { 0, 9, 0 })]
        [TestCase(new int[] { 5 }, 3, new int[] { 5 })]
        [TestCase(new int[] { }, 2, new int[] { })]
        [TestCase(new int[] { 3, 4, 2, 8, 1, 7 }, 3, new int[] { 4, 2, 8, 1, 7 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, 1, new int[] { 3, 4, 5, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, 3, new int[] { 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, 6, new int[] { 3, 4, 5, 1, 5, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, 7, new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1 })]
        [TestCase(new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 }, 0, new int[] { 3, 4, 5, 1, 5, 6, 6, 2, 1, 1, 2, 4, 4, 2, 8, 1, 7 })]
        public void RemoveByValueFirstMatchInLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveByValueFirstMatchInList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 22. Удаление всех по значению
        [TestCase(7, new int[] { 7, 3, 6, 7, 1 }, 2)]
        [TestCase(1, new int[] { 1 }, 1)]
        [TestCase(9, new int[] { 9, 9, 9, 9, 9, 9, 9, 5, 0 }, 7)]
        public void RemoveByValueAllMatchInLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveByValueAllMatchInList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 24. Добавление списка в конец
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 5, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 5, 1, -10, 5, 0, 4, 9, 0 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 2 }, new int[] { }, new int[] { 2 })]
        public void AddNewListToEndLinkedListTests(int[] list, int[] addList, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddNewListToEndList(addList);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 25. Добавление списка в начало
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 5, 1, -10, 5 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 2 }, new int[] { }, new int[] { 2 })]
        public void AddNewListToBeginLinkedListTests(int[] list, int[] addList, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddNewListToBeginList(addList);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 26. Добавление списка по индексу
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0 }, 3, new int[] { 0, 4, 9, 0, 4, 9, 0, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 0, 4, 9, 0 }, 1, new int[] { 5, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 0, 4, 9, 0 }, 2, new int[] { 5, 1, 0, 4, 9, 0, -10, 5 })]
        [TestCase(new int[] { }, new int[] { }, 0, new int[] { })]
        [TestCase(new int[] { }, new int[] { 3 }, 0, new int[] { 3 })]
        [TestCase(new int[] { 2 }, new int[] { }, 0, new int[] { 2 })]
        [TestCase(new int[] { 3 }, new int[] { }, 1, new int[] { 3 })]
        public void AddNewListByIndexInLinkedListTests(int[] list, int[] addList, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddNewListByIndexInList(index, addList);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

    }
}
