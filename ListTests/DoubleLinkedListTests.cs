using NUnit.Framework;
using List;

namespace ListTests
{
    class DoubleDoubleLinkedListTests
    {
        // 1. Добавление значения в конец
        [TestCase(new int[] { 0, 4, -1, 5 }, 9, new int[] { 0, 4, -1, 5, 9 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 5, 1, -10, 3 })]
        public void AddValueLastInDoubleLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.AddValueLastInList(value);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 2. Добавление значения в начало
        [TestCase(new int[] { 0, 4, -1, 5 }, 7, new int[] { 7, 0, 4, -1, 5 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 3, 5, 1, -10 })]
        public void AddValueByFirstInDoubleLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.AddValueByFirstInList(value);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 3. Добавление значения по индексу
        [TestCase(new int[] { 0, 4, -1, 5 }, 9, 2, new int[] { 0, 4, 9, -1, 5 })]
        [TestCase(new int[] { }, 5, 0, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 0, 3, new int[] { 5, 1, -10, 0 })]
        public void AddValueByIndexInDoubleLinkedListTests(int[] list, int value, int index, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.AddValueByIndexInList(index, value);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 4. Удаление из конца одного элемента
        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 0, 4, -1 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, new int[] { 5, 1 })]
        public void RemoveValueInEndInDoubleLinkedListTests(int[] list, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveValueInEndInList();
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 5. Удаление из начала одного элемента
        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 4, -1, 5 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, new int[] { 1, -10 })]
        public void RemoveValueInStartInDoubleLinkedListTests(int[] list, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveValueInStartInList();
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 6. Удаление по индексу одного элемента
        [TestCase(new int[] { 0, 4, -1, 5 }, 2, new int[] { 0, 4, 5 })]
        [TestCase(new int[] { 5 }, 0, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, 2, new int[] { 5, 1 })]
        public void RemoveValueByIndexInDoubleLinkedListTests(int[] list, int index, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveValueByIndexInList(index);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 7. Удаление из конца N элементов
        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 6, new int[] { 0, 4, 9 })]
        [TestCase(new int[] { 5 }, 1, new int[] { })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, new int[] { 5, 1, -10 })]
        public void RemoveGivenQuantityOfValuesTheEndByDoubleLinkedListTests(int[] list, int qty, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveGivenQuantityOfValuesTheEndByList(qty);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 8. Удаление из начала N элементов
        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 6, new int[] { 8, -1, 5 })]
        [TestCase(new int[] { 5 }, 1, new int[] { })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, new int[] { 1, -10, 5 })]
        public void RemoveGivenQuantityOfValuesTheStartByDoubleLinkedListTests(int[] list, int qty, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveGivenQuantityOfValuesTheStartByList(qty);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 9. Удаление по индексу N элементов
        [TestCase(new int[] { 0, 4, 9, 0 }, 1, 1, new int[] { 0, 9, 0 })]
        [TestCase(new int[] { 5 }, 0, 0, new int[] { 5 })]
        [TestCase(new int[] { 3, 4, 2, 8, 1, 7 }, 0, 3, new int[] { 8, 1, 7 })]
        [TestCase(new int[] { 3, 4, 5, 4, 4, 2, 8, 1, 7 }, 3, 5, new int[] { 3, 4, 5, 7 })]
        public void RemoveGivenQuantityOfValuesByIndexInDoubleLinkedListTests(int[] list, int index, int qty, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveGivenQuantityOfValuesByIndexInList(index, qty);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 12. Первый индекс по значению
        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 8, 4)]
        [TestCase(new int[] { 5 }, 5, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, 1)]
        public void GetFirstIndexByValueTests(int[] list, int value, int expected)
        {
            DoubleLinkedList array = new DoubleLinkedList(list);
            int actual = array.GetFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        // 13. Изменение по индексу
        [TestCase(new int[] { 0, 4, 9, 0 }, 3, 45, new int[] { 0, 4, 9, 45 })]
        [TestCase(new int[] { 5 }, 0, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, 7, new int[] { 5, 7, -10, 5 })]
        public void ChangeValueByIndexTests(int[] list, int index, int value, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.ChangeValueByIndex(index, value);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 14. Реверс (123 -> 321)
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 9, 4, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 3 }, new int[] { 3, 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 5, -10, 1, 5 })]
        public void ReversDoubleLinkedListTests(int[] list, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.ReversList();
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 15. Поиск значения максимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 9)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 5)]
        [TestCase(new int[] { 5, 1, -10, 20 }, 20)]
        public void FindMaxValueByDoubleLinkedListTests(int[] list, int expected)
        {
            DoubleLinkedList array = new DoubleLinkedList(list);
            int actual = array.FindMaxValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 16. Поиск значения минимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 0)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 5, 1, -10, 5 }, -10)]
        [TestCase(new int[] { 5, 1, -10, -20 }, -20)]
        public void FindMinValueByDoubleLinkedListTests(int[] list, int expected)
        {
            DoubleLinkedList array = new DoubleLinkedList(list);
            int actual = array.FindMinValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 17. Поиск индекс максимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 2)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 0)]
        [TestCase(new int[] { 5, 1, -10, 20 }, 3)]
        public void FindIndexMaxValueByDoubleLinkedListTests(int[] list, int expected)
        {
            DoubleLinkedList array = new DoubleLinkedList(list);
            int actual = array.FindIndexMaxValueByList();
            Assert.AreEqual(expected, actual);
        }

        // 18. Поиск индекс минимального элемента
        [TestCase(new int[] { 0, 4, 9, 0 }, 0)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 2)]
        [TestCase(new int[] { 5, 1, -10, -20 }, 3)]
        public void FindIndexMinValueByDoubleLinkedListTests(int[] list, int expected)
        {
            DoubleLinkedList array = new DoubleLinkedList(list);
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
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.SortAscending();
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
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
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.SortDescending();
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
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
        public void RemoveByValueFirstMatchInDoubleLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.RemoveByValueFirstMatchInList(value);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 22. Удаление всех по значению
        [TestCase(7, new int[] { 7, 3, 6, 7, 1 }, 2)]
        [TestCase(1, new int[] { 1 }, 1)]
        [TestCase(9, new int[] { 9, 9, 9, 9, 9, 9, 9, 5, 0 }, 7)]
        public void RemoveByValueAllMatchInDoubleLinkedListTests(int value, int[] actualArray, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(actualArray);
            int actual = list.RemoveByValueAllMatchInList(value);
            Assert.AreEqual(expected, actual);
        }

        // 24. Добавление списка в конец
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 5, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 5, 1, -10, 5, 0, 4, 9, 0 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 2 }, new int[] { }, new int[] { 2 })]
        public void AddNewListToEndDoubleLinkedListTests(int[] list, int[] addList, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.AddNewListToEndList(addList);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 25. Добавление списка в начало
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 5, 1, -10, 5 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 2 }, new int[] { }, new int[] { 2 })]
        public void AddNewListToBeginDoubleLinkedListTests(int[] list, int[] addList, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.AddNewListToBeginList(addList);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
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
        public void AddNewListByIndexInDoubleLinkedListTests(int[] list, int[] addList, int index, int[] expectedArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(list);
            actual.AddNewListByIndexInList(index, addList);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }
    }
}