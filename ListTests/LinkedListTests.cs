using NUnit.Framework;
using List;
using System;
using System.Collections.Generic;

namespace ListTests
{
    class LinkedListTests
    {











        [TestCase(new int[] { 0, 4, -1, 5 }, 9, new int[] { 0, 4, -1, 5, 9})]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 5, 1, -10, 3 })]
        public void AddValueLastInLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueLastInLinkedList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 4, -1, 5 }, 7, new int[] { 7, 0, 4, -1, 5 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 3, 5, 1, -10 })]
        public void AddValueByFirstInLinkedListTests(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByFirstInLinkedList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, -1, 5 }, 9, 2, new int[] { 0, 4, 9, -1, 5 })]
        [TestCase(new int[] { }, 5, 0, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 0, 3, new int[] { 5, 1, -10, 0 })]
        public void AddValueByIndexInLinkedListTests(int[] list, int value, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByIndexInLinkedList(value, index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 0, 4, -1 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, new int[] { 5, 1 })]
        public void RemoveValueInEndInLinkedListTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveValueInEndInLinkedList();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 4, -1, 5 }, new int[] { 4, -1, 5 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, new int[] { 1, -10 })]
        public void RemoveValueInStartInLinkedListTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveValueInStartInLinkedList();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, -1, 5 },  2, new int[] { 0, 4, 5 })]
        [TestCase(new int[] { 5 }, 0, new int[] { })]
        [TestCase(new int[] { 5, 1, -10 }, 2, new int[] { 5, 1 })]
        public void RemoveValueByIndexInLinkedListTests(int[] list, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveValueByIndexInLinkedList(index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 2, 6, new int[] { 0, 4, 5 })]
        [TestCase(new int[] { 5 }, 0, 1, new int[] { })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 3, 1, new int[] { 5, 1, -10 })]
        public void RemoveGivenQuantityOfValuesByIndexInLinkedListTests(int[] _list, int index, int qty, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(_list);
            actual.RemoveGivenQuantityOfValuesByIndexInLinkedList(index, qty);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, 9, 9, 8, 7, 8, -1, 5 }, 8, 4)]
        [TestCase(new int[] { 5 }, 5, 0)]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, 1)]
        public void GetFirstIndexByValueTests(int[] _list, int value, int  expected)
        {
            LinkedList array = new LinkedList(_list);
            int actual = array.GetFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, 9, 0 }, 3, 45, new int[] { 0, 4, 9, 45 })]
        [TestCase(new int[] { 5 }, 0, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, 1, 7, new int[] { 5, 7, -10, 5 })]
        public void ChangeValueByIndexTests(int[] _list, int index, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(_list);
            actual.ChangeValueByIndex(index, value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 9, 4, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 5, -10, 1, 5 })]
        public void ReversLinkedListTests(int[] _list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(_list);
            actual.ReversLinkedList();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 19. Сортировка по возрастанию
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 0, 4, 9 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { -10, 1, 5, 5 })]
        public void SortAscendingTests(int[] list, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.SortAscending();
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
            LinkedList array = new LinkedList(list);
            LinkedList addArray = new LinkedList(addList);
            LinkedList actual = array.AddNewListToEndLinkedList(array, addArray);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        // 25. Добавление списка в начало
        [TestCase(new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 0, 4, 9, 0 })]
        [TestCase(new int[] { 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 5 })]
        [TestCase(new int[] { 5, 1, -10, 5 }, new int[] { 0, 4, 9, 0 }, new int[] { 0, 4, 9, 0, 5, 1, -10, 5 })]
        public void AddNewListToBeginLinkedListTests(int[] list, int[] addList, int[] expectedArray)
        {
            LinkedList array = new LinkedList(list);
            LinkedList addArray = new LinkedList(addList);
            LinkedList actual = array.AddNewListToBeginLinkedList(array, addArray);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        

    }
}
