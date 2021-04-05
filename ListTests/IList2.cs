using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace List
{
    public class IList2
    {
        public static bool AddValueLastInList<T>(int[] actualArray, int value, int[] expectedArray) where T : IList
        {
            var actual = (T)Activator.CreateInstance(typeof(T), actualArray);
            var expected = (T)Activator.CreateInstance(typeof(T), expectedArray);
            actual.AddValueLastInList(value);
            return Equals(actual, expected);
        }
    }
    public class Test
    {
        private Type[] _types = new[] { typeof(ArrayList), typeof(LinkedList), typeof(DoubleLinkedList) };
        [TestCase(new[] { 1, 2, 3 }, 4, new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 1, 2 }, 3, new[] { 1, 2, 3 })]
        [TestCase(new int[0], 1, new[] { 1 })]
        public void AddValueLastInList(int[] actualArray, int value, int[] expectedArray)
        {
            foreach (Type type in _types)
            {
                MethodInfo method = typeof(IList2).GetMethod(nameof(IList2.AddValueLastInList));
                MethodInfo generic = method.MakeGenericMethod(type);
                var args = new object[] { actualArray, value, expectedArray };
                Assert.IsTrue((bool)generic.Invoke(this, args));
            }
        }
    }
}