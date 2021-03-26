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
        [TestCase(new int[] { 5, 1, -10 }, 2, 1, new int[] { 5, 1 })]
        public void RemoveGivenQuantityOfValuesByIndexInLinkedListTests(int[] list, int index, int qty, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.RemoveGivenQuantityOfValuesByIndexInLinkedList(index, qty);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
