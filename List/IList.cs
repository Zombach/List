namespace List
{
    public interface IList
    {
        // 1. Добавление значения в конец
        void AddValueLastInList(int value)
        {
        }

        // 2. Добавление значения в начало
        void AddValueByFirstInList(int value)
        {
        }

        // 3. Добавление значения по индексу
        void AddValueByIndexInList(int index, int value)
        {
        }

        // 4. Удаление из конца одного элемента
        void RemoveValueInEndInList()
        { 
        }

        // 5. Удаление из начала одного элемента
        void RemoveValueInStartInList()
        {
        }

        // 6. Удаление по индексу одного элемента
        void RemoveValueByIndexInList(int index)
        {
        }

        //7. Удаление из конца N элементов
        void RemoveGivenQuantityOfValuesTheEndByList(int count)
        {
        }

        // 8. Удаление из начала N элементов
        void RemoveGivenQuantityOfValuesTheStartByList(int count)
        {
        }

        // 9. Удаление по индексу N элементов
        void RemoveGivenQuantityOfValuesByIndexInList(int index, int count = 1)
        {
        }

        // 12. Первый индекс по значению
        //public int GetFirstIndexByValue(int value)
        int GetFirstIndexByValue(int value)
        {
            return GetFirstIndexByValue(value);
        }

        // 13. Изменение по индексу
        void ChangeValueByIndex(int index, int value)
        {
        }

        // 14. Реверс (123 -> 321)
        void ReversList()
        {
        }

        // 15. Поиск значения максимального элемента
        int FindMaxValueByList()
        {
            return FindMaxValueByList();
        }

        // 16. Поиск значения минимального элемента
        //public int FindMinValueByList()
        int FindMinValueByList()
        {
            return FindMinValueByList();
        }

        // 17. Поиск индекс максимального элемента
        //public int FindIndexMaxValueByList()
        int FindIndexMaxValueByList()
        {
            return FindIndexMaxValueByList();
        }

        // 18. Поиск индекс минимального элемента
        //public int FindIndexMinValueByList()
        int FindIndexMinValueByList()
        {
            return FindIndexMinValueByList();
        }


        // 19. Сортировка по возрастанию
        void SortAscending()
        {
        }

        // 20. Сортировка по убыванию
        void SortDescending()
        {
        }

        // 21. Удаление по значению первого
        //public int RemoveByValueFirstMatchInList(int value)
        int RemoveByValueFirstMatchInList(int value)
        {
            return RemoveByValueFirstMatchInList(value);
        }

        // 22. Удаление по значению всех(?вернуть кол-во)
        //public int RemoveByValueAllMatchInList(int value)
        int RemoveByValueAllMatchInList(int value)
        {
            return RemoveByValueAllMatchInList(value);
        }

        // 24. Добавление списка в конец
        void AddNewListToEndList(int[] array)
        {
        }

        // 25. Добавление списка в начало
        void AddNewListToBeginList(int[] array)
        {
        }

        // 26. Добавление списка по индексу
        void AddNewListByIndexInList(int index, int[] array)
        {
        }
    }
}
