using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Exceptions
    {
        public static void CheckExceptionIndex(int index, int Length)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static void CheckNullReferenceException(int Length)
        {
            if (Length <= 0)
            {
                throw new NullReferenceException();
            }
        }
        public static void CheckExceptionByCountToRemove(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("нельзя удалить отрицательное количество элементов");
            }
        }
    }
}
