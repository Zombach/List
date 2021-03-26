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
        public void AddValueLastInLinkedListTest(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueLastInLinkedList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 4, -1, 5 }, 7, new int[] { 7, 0, 4, -1, 5 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, new int[] { 3, 5, 1, -10 })]
        public void AddValueByFirstInLinkedListTest(int[] list, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByFirstInLinkedList(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 4, -1, 5 }, 9, 2, new int[] { 0, 4, 9, -1, 5 })]
        [TestCase(new int[] { }, 5, 0, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 0, 3, new int[] { 5, 1, -10, 0 })]
        public void AddValueByIndexInLinkedListTest(int[] list, int value, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByIndexInLinkedList(value, index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }



    }
}
