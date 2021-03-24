using System;

namespace List

{
    public class ArrayList
    {
        public int Length { set; private get; }
        private int[] _list;

        public int this[int index]
        {
            get
            {
                // CheckIndexException(index);
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        // 23.1 3 конструктора (пустой)  
        public ArrayList()                                               
        {
            Length = 0;
            _list = new int[10];
        }

        // 23.2 3 конструктора (на основе одного элемента)
        public ArrayList(int value) 
        {
            Length = 1;
            _list = new int[10];
            _list[0] = value;
        }

        // 23.3 3 конструктора (на основе массива )
        public ArrayList(int[] list)    
        {
            _list = list;
            Length = _list.Length;
        }

        // 1. Добавление значения в конец
        public void AddValueLastInList(int value)   
        {
            AddValueByIndexInList(Length, value);
        }

        // 2. Добавление значения в начало
        public void AddValueByFirstInList(int value)    
        {
            AddValueByIndexInList(0, value);
        }

        // 3. Добавление значения по индексу
        public void AddValueByIndexInList(int index, int value )    
        {
            CheckUpSize();
            for (int i = Length; i > index; i--)
            {
                _list[i] = _list[i - 1];
            }
            _list[index] = value;
            Length++;
        }

        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInList()    
        {
            RemoveGivenQuantityOfValuesByIndexInList(Length);
        }

        // 5. Удаление из начала одного элемента
        public void RemoveValueInStartInList()  
        {
            RemoveGivenQuantityOfValuesByIndexInList(0);
        }

        // 6. Удаление по индексу одного элемента
        public void RemoveValueByIndexInList(int index) 
        {
            RemoveGivenQuantityOfValuesByIndexInList(index);
        }

        // 7. Удаление из конца N элементов
        public void RemoveGivenQuantityOfValuesTheEndByList(int count)  
        {
            RemoveGivenQuantityOfValuesByIndexInList(Length, count);
        }

        // 8. Удаление из начала N элементов
        public void RemoveGivenQuantityOfValuesTheStartByList(int count)    
        {
            RemoveGivenQuantityOfValuesByIndexInList(0, count);
        }

        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInList(int index, int count = 1)  
        {
            for (int i = index; i < Length - count; i++)
            {
                _list[i] = _list[i + count];
            }
            CheckDownSize(count);
        }

        // 12. Первый индекс по значению
        public int GetFirstIndexByValue(int value)  
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_list[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // 13. Изменение по индексу
        public void ChangeValueByIndex(int index,int value) 
        {
            _list[index] = value;                  
        }

        // 14. Реверс (123 -> 321)
        public void ReversList()    
        {
            int halfLength = Length / 2;
            for (int i = 0; i < halfLength; i ++)
            {
                int tmp = _list[i];
                _list[i] = _list[Length - i - 1];
                _list[Length - i - 1] = tmp;
            }
        }

        // 15. Поиск значения максимального элемента
        public int FindMaxValueByList() 
        {
            return _list[FindIndexMaxValueByList()];
        }

        // 16. Поиск значения минимального элемента
        public int FindMinValueByList() 
        {
            return _list[FindIndexMinValueByList()];
        }

        // 17. Поиск индекс максимального элемента
        public int FindIndexMaxValueByList()
        {
            int index = 0;
            int tmp = _list[index];
            for (int i = 0; i < Length; i++)
            {
                if (tmp < _list[i])
                {
                    tmp = _list[i];
                    index = i;
                }
            }
            return index;
        }

        // 17. Поиск индекс минимального элемента
        public int FindIndexMinValueByList()    
        {
            int index = 0;
            int tmp = _list[index];
            for (int i = 0; i < Length; i++)
            {
                if (tmp > _list[i])
                {
                    tmp = _list[i];
                    index = i;
                }
            }
            return index;
        }

        // 19. Сортировка по возрастанию
        public void SortAscending() 
        {
            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_list[j] < _list[i])
                    {
                        tmp = _list[j];
                        _list[j] = _list[i];
                        _list[i] = tmp;
                    }
                }
            }
        }

        // 20. Сортировка по убыванию
        public void SortDescending()                        
        {
            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_list[j] > _list[i])
                    {
                        tmp = _list[j];
                        _list[j] = _list[i];
                        _list[i] = tmp;
                    }
                }
            }
        }

        // 21. Удаление по значению первого
        public void RemoveByValueFirstMatchInList(int value)                    
        {
            RemoveByValueAllMatchInList(value, true);
        }

        // 22. Удаление по значению всех(?вернуть кол-во)
        public void RemoveByValueAllMatchInList(int value, bool oneElement = false)       
        {
            for (int i = 0; i < Length; i++)
            {
                if (_list[i] == value)
                {
                    RemoveGivenQuantityOfValuesByIndexInList(i);
                    i--;
                    if (oneElement)
                    {
                        break;
                    }
                }
            }
        }

        // 24. Добавление списка в конец
        public void AddNewListToEndList(int[] array)                   
        {
            AddNewListByIndexInList(Length, array);
        }

        // 25. Добавление списка в начало
        public void AddNewListToBeginList(int[] array)                    
        {
            AddNewListByIndexInList(0, array);
        }

        // 26. Добавление списка по индексу
        public void AddNewListByIndexInList(int index, int[] array)                   
        {
            CheckUpSize(array.Length);
            int generalLength = Length + array.Length;
            int length = generalLength - array.Length - index;

            for (int i = 0; i < length; i++)
            {
                _list[generalLength - i - 1] = _list[length - i - 1 + index];
            }

            for (int i = 0; i < array.Length; i++)
            {
                _list[index++] = array[i];
                Length++;
            }

        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if (this.Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < this.Length; i++)
            {
                if (this._list[i] != arrayList._list[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string arrayToString = "";
            for (int i = 0; i < Length; i++)
            {
                arrayToString += $"{_list[i]} ";
            }
            return arrayToString;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        private void CheckExceptionIndex(int index)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException("индекс находится за пределами массива входит в массив");
            }
        }
        private void CheckExceptionByZeroLength()
        {
            if (Length <= 0)
            {
                throw new IndexOutOfRangeException("массив пустой");
            }
        }

        private void CheckExceptionByCountToRemove(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("нельзя удалить отрицательное количество элементов");
            }
        }
        private void CheckUpSize(int length = 0)
        {
            if (Length + length >= _list.Length)
            {
                UpSize(length);
            }
        }
        private void CheckDownSize(int length = 1)
        {
            Length -= length;
            if (Length < (_list.Length/ 2))
            {
                DownSize();
            }
        }
        private void UpSize(int length = 0)
        {
            int newLength = (int)((_list.Length + length + 1) * 1.33d);
            int[] tmpList = new int[newLength];
            for (int i = 0; i < _list.Length; i++)
            {
                tmpList[i] = _list[i];
            }
            _list = tmpList;
        }
        private void DownSize()
        {
            int newLength = (int)(_list.Length * 0.67d + 1);
            int[] tmpList = new int[newLength];
            for (int i = 0; i < tmpList.Length; i++)
            {
                tmpList[i] = _list[i];
            }
            _list = tmpList;
        }        
    }
}