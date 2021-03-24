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
    }
}