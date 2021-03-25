using NUnit.Framework;
using List;
using System;
using System.Collections.Generic;

namespace ListTests
{
    class LinkedListTests
    {
        [TestCase(new int[] { 0, 4, -1, 5 }, 4, new int[] { 0, 4, -1, 5, 4 })]
        [TestCase(new int[] { }, -2, new int[] { -2 })]
        [TestCase(new int[] { 5, 1, -10 }, 0, new int[] { 5, 1, -10, 0 })]
        public void Add_Test(int[] array, int value, int[] expectedArray)
        {
            //LinkedList actual = new LinkedList(array);
            //actual.Add(value);
            //LinkedList expected = new LinkedList(expectedArray);
            //Assert.AreEqual(expected, actual);
        }

       
    }
}
