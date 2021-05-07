using System;

namespace List
{
    public static class Exceptions
    {
        public static void CheckExceptionIndex(int index, int length)
        {
            if (index < 0 || index > length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static void CheckNullReferenceException(int length)
        {
            if (length <= 0)
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
        public static void CheckExceptionByCountToRemoveInLast(int length, int qty)
        {
            if (length < qty)
            {
                throw new ArgumentException("Вы пытаетесь удалить, больше элементов, чем их есть");
            }
        }
    }
}
