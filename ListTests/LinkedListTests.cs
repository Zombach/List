using NUnit.Framework;
using List;
using System;
using System.Collections.Generic;

namespace ListTests
{
    class LinkedListTests
    {
        [TestCase(new int[] { 0, 4, -1, 5 }, 2, 9, new int[] { 0, 4, 9, -1, 5 })]
        [TestCase(new int[] { }, 0, 5, new int[] { 5 })]
        [TestCase(new int[] { 5, 1, -10 }, 3, 0, new int[] { 5, 1, -10, 0 })]
        public void Add_Test(int[] list, int index, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(list);
            actual.AddValueByIndexInLinkedList(value, index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected, actual);
        }


    }
}
