using System;
using System.Collections.Generic;
using System.Text;

namespace List

/*
10. Вернуть длину
11. Доступ по индексу 



 */
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

        public ArrayList()                                               // 23.1 3 конструктора (пустой, на основе одного элемента, на основе массива )
        {
            Length = 0;
            _list = new int[10];
        }

        public ArrayList(int value)                                      // 23.2 3 конструктора (пустой, на основе одного элемента, на основе массива )
        {
            Length = 1;
            _list = new int[10];
            _list[0] = value;
        }

        public ArrayList(int[] list)                                     // 23.3 3 конструктора (пустой, на основе одного элемента, на основе массива )
        {
            _list = list;
            Length = _list.Length;
        }

        public void AddValueLastInList(int value)                                               // 1. Добавление значения в конец
        {
            AddValueByIndexInList(Length, value);
        }
        public void AddValueByFirstInList(int value)                                            // 2. Добавление значения в начало
        {
            AddValueByIndexInList(value, 0);
        }
        public void AddValueByIndexInList(int index, int value )                                // 3. Добавление значения по индексу
        {
            CheckUpSize();
            for (int i = Length; i > index; i--)
            {
                _list[i] = _list[i - 1];
            }
            _list[index] = value;
            Length++;
        }

        public void RemoveValueInEndInList()                                                    // 4. Удаление из конца одного элемента
        {
            RemoveGivenQuantityOfValuesByIndexInList(Length);
        }
        public void RemoveValueInStartInList()                                                  // 5. Удаление из начала одного элемента
        {
            RemoveGivenQuantityOfValuesByIndexInList(0);
        }
        public void RemoveValueByIndexInList(int index)                                         // 6. Удаление по индексу одного элемента
        {
            RemoveGivenQuantityOfValuesByIndexInList(index);
        }

        public void RemoveGivenQuantityOfValuesTheEndByList(int count)                          // 7. Удаление из конца N элементов
        {
            RemoveGivenQuantityOfValuesByIndexInList(Length, count);
        }        
        public void RemoveGivenQuantityOfValuesTheStartByList(int count)                        // 8. Удаление из начала N элементов
        {
            RemoveGivenQuantityOfValuesByIndexInList(0, count);
        }
        public void RemoveGivenQuantityOfValuesByIndexInList(int index, int count = 1)          // 9. Удаление по индексу N элементов
        {
            for (int i = index; i < Length - count; i++)
            {
                _list[i] = _list[i + count];
            }
            CheckDownSize(count);
        }


        public int GetFirstIndexByValue(int value)                   // 12. Первый индекс по значению
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
        public void ChangeValueByIndex(int index,int value)             // 13. Изменение по индексу
        {
            _list[index] = value;                  
        }

        public void ReversList()
        {
            int halfLength = Length / 2;
            for (int i = 0; i < halfLength; i ++)
            {
                int tmp = _list[i];
                _list[i] = _list[Length - i - 1];
                _list[Length - i - 1] = tmp;
            }
        }                           // 14. Реверс (123 -> 321)

        public int FindMaxValueByList()                        // 15. Поиск значения максимального элемента
        {
            return _list[FindIndexMaxValueByList()];
        }
        public int FindMinValueByList()                    // 16. Поиск значения минимального элемента
        {
            return _list[FindIndexMinValueByList()];
        }
        public int FindIndexMaxValueByList()                        // 17. Поиск индекс максимального элемента
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
        public int FindIndexMinValueByList()                    // 18. Поиск индекс минимального элемента
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

        public void SortAscending()                          // 19. Сортировка по возрастанию
        {

        }

        public void SortDescending()                        // 20. Сортировка по убыванию
        {

        }

        public void RemoveByValueFirstMatchInList(int value)                    // 21. Удаление по значению первого
        {
            RemoveByValueAllMatchInList(value, true);
        }

        public void RemoveByValueAllMatchInList(int value, bool oneElement = false)       // 22. Удаление по значению всех(?вернуть кол-во)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_list[i] == value)
                {
                    RemoveGivenQuantityOfValuesByIndexInList(i);
                    if (oneElement)
                    {
                        break;
                    }
                }
            }
        }

        public void AddNewListToEndList(int[] array)                   // 24. Добавление списка в конец
        {
            AddNewListByIndexInList(Length, array);
        }
        public void AddNewListToBeginList(int[] array)                    // 25. Добавление списка в начало
        {
            AddNewListByIndexInList(0, array);
        }
        public void AddNewListByIndexInList(int index, int[] array)                   // 26. Добавление списка по индексу
        {
            CheckUpSize(array.Length);
            int length = Length - array.Length;

            for (int i = index; i < length; i++)
            {
                _list[i] = _list[i - 1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                _list[index++] = array[i];
            }
        }



        private void CheckUpSize(int length = 0)
        {
            if (Length + length == _list.Length)
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
    }
}