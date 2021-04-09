using System;

namespace List
{
    public class DoubleLinkedList : IList
    {
        public int Length { get; private set; }

        private DoubleLink _root;
        private DoubleLink _tail;
        private DoubleLink _previous;

        public int this[int index]
        {
            get
            {
                return GetNodeByIndex(index).Value;
            }
            set
            {
                GetNodeByIndex(index).Value = value;
            }
        }

        // 23.1 3 конструктора (пустой)  
        public DoubleLinkedList()
        {
            Length = 0;
            _root = null;
            _tail = _root;
        }

        // 23.2 3 конструктора (на основе одного элемента)
        public DoubleLinkedList(int value)
        {
            Length = 1;
            _root = new DoubleLink(value);
            _tail = _root;
        }

        // 23.3 3 конструктора (на основе массива )
        public DoubleLinkedList(int[] values)
        {
            if (values.Length != 0)
            {
                if (Length == 0)
                {
                    AddValueByFirstInList(values[0]);
                }
                for (int i = 1; i < values.Length; i++)
                {
                    AddValueLastInList(values[i]);
                }
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = _root;
            }
        }

        // 1. Добавление значения в конец
        public void AddValueLastInList(int value)
        {
            if (Length >= 1)
            {
                _tail.LinkNext = new DoubleLink(value);
                _previous = _tail;
                _tail = _tail.LinkNext;                
                Length++;
            }
            else if (Length == 0)
            {
                _tail.LinkNext = new DoubleLink(value);
                _tail = _tail.LinkNext;
                Length++;
            }
            else
            {
                AddValueByFirstInList(value);
            }
        }

        // 2. Добавление значения в начало
        public void AddValueByFirstInList(int value)
        {
            DoubleLink _newDoubleLink = new DoubleLink(value);
            if (Length != 0)
            {
                _newDoubleLink.LinkNext = _root;
                _root = _newDoubleLink;
                _previous = _root;
            }
            else
            {
                _root = _newDoubleLink;
                _tail = _root;
                _previous = null;
            }
            Length++;
        }

        // 3. Добавление значения по индексу
        public void AddValueByIndexInList(int value, int index)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            if (NodeBegin(value, index) || NodeLast(value, index))
            {
                return;
            }
            DoubleLink current = GetNodeByIndex(index - 1);
            DoubleLink _new = new DoubleLink(value);
            _new.LinkNext = current.LinkNext;
            current.LinkNext = _new;
            Length++;
        }


        private bool NodeBegin(int value, int index)
        {
            bool check = false;
            if (index == 0)
            {
                AddValueByFirstInList(value);
                check = true;
            }
            return check;
        }

        private bool NodeLast(int value, int index)
        {
            bool check = false;
            if (index == Length)
            {
                AddValueLastInList(value);
                check = true;
            }
            return check;
        }


        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInList()
        {
            if (Length > 1)
            {
                DoubleLink current = GetNodeByIndex(Length - 2);
                current.LinkNext = null;
                _tail = current;
                Length--;
            }
            else
            {
                _root = null;
                Length = 0;
            }

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
        public void RemoveGivenQuantityOfValuesTheEndByList(int qty)
        {
            RemoveGivenQuantityOfValuesByIndexInList(Length - 1, qty);
        }

        // 8. Удаление из начала N элементов
        public void RemoveGivenQuantityOfValuesTheStartByList(int qty)
        {
            RemoveGivenQuantityOfValuesByIndexInList(0, qty);
        }

        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInList(int index, int qty = 1)
        {
            DoubleLink current = _root;
            int count = 0;
            if (index == 0)
            {
                for (int i = 0; i < qty; i++)
                {
                    _root = _root.LinkNext;
                }
            }
            else if (index == Length - 1)
            {
                current = _root;
                for (int j = 0; j < Length - 1 - qty; j++)
                {
                    current = current.LinkNext;
                }
                current.LinkNext = null;
                _tail = current;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (index == count + 1)
                    {
                        if (index == Length - 1 - qty)
                        {
                            for (int j = 0; j < qty; j++)
                            {
                                current.LinkNext = current.LinkNext.LinkNext;
                            }
                        }
                        else
                        {
                            current.LinkNext = current.LinkNext.LinkNext;
                        }
                        if (current.LinkNext == null)
                        {
                            _tail = current;
                        }
                        break;
                    }
                    current = current.LinkNext;
                    count++;
                }
            }
            Length -= qty;
        }

        // 12. Первый индекс по значению
        public int GetFirstIndexByValue(int value)
        {
            DoubleLink current = _root;
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    index = i;
                    break;
                }
                current = current.LinkNext;
            }
            return index;
        }

        // 13. Изменение по индексу
        public void ChangeValueByIndex(int index, int value)
        {
            DoubleLink current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (i == index)
                {
                    current.Value = value;
                    break;
                }
                current = current.LinkNext;
            }
        }

        // 14. Реверс (123 -> 321)
        public void ReversList()
        {
            if (Length > 1)
            {
                _tail = _root;
                DoubleLink previous = null;
                DoubleLink next = _root.LinkNext;
                while (!(_root.LinkNext is null))
                {
                    _root.LinkNext = previous;
                    previous = _root;
                    _root = next;
                    next = next.LinkNext;
                }
                _root.LinkNext = previous;
            }
        }

        // 15. Поиск значения максимального элемента
        public int FindMaxValueByList()
        {
            return FindIndexMaxOrMinValueByDoubleLinkedList(maxOrMin: true, value: true);
        }

        // 16. Поиск значения минимального элемента
        public int FindMinValueByList()
        {
            return FindIndexMaxOrMinValueByDoubleLinkedList(maxOrMin: false, value: true);
        }

        // 17. Поиск индекс максимального элемента
        public int FindIndexMaxValueByList()
        {
            return FindIndexMaxOrMinValueByDoubleLinkedList(maxOrMin: true);
        }

        // 18. Поиск индекс минимального элемента
        public int FindIndexMinValueByList()
        {
            return FindIndexMaxOrMinValueByDoubleLinkedList(maxOrMin: false);
        }

        private int FindIndexMaxOrMinValueByDoubleLinkedList(bool maxOrMin = true, bool value = false)
        {
            Exceptions.CheckNullReferenceException(Length);
            DoubleLink current = _root;
            int tmpValue = _root.Value;
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (FindMaxOrMin(current, maxOrMin))
                {
                    index = i;
                    tmpValue = _root.Value;
                }
                _root = _root.LinkNext;
            }
            if (value)
            {
                return tmpValue;
            }
            return index;
        }

        public bool FindMaxOrMin(DoubleLink current, bool maxOrMin)
        {
            if (maxOrMin && current.Value < _root.Value || !maxOrMin && current.Value > _root.Value)
            {
                return true;
            }
            return false;
        }

        // 19. Сортировка по возрастанию
        public void SortAscending()
        {
            SortingList(true);
        }

        // 20. Сортировка по убыванию
        public void SortDescending()
        {
            SortingList(false);
        }
        private void SortingList(bool ascendingOrDescending = true)
        {
            if (Length == 0) return;
            DoubleLink temp = _tail;
            for (DoubleLink current = _root; temp.LinkNext != _root.LinkNext;)
            {
                if (SortAscendingOrDescending(temp, current, ascendingOrDescending))
                {
                    int tmp = current.Value;
                    current.Value = temp.Value;
                    temp.Value = tmp;
                }
                if (current.LinkNext == temp)
                {
                    temp = current;
                    current = _root;
                    continue;
                }
                current = current.LinkNext;
            }
        }
        private bool SortAscendingOrDescending(DoubleLink temp, DoubleLink current, bool ascendingOrDescending)
        {
            if (ascendingOrDescending && temp.Value < current.Value || !ascendingOrDescending && temp.Value > current.Value)
            {
                return true;
            }
            return false;
        }

        // 21. Удаление по значению первого
        public void RemoveByValueFirstMatchInList(int value)
        {
            RemoveByValusInDoubleLinkedList(value, false);
        }

        // 22. Удаление по значению всех
        public void RemoveByValueAllMatchInList(int value)
        {
            RemoveByValusInDoubleLinkedList(value);
        }

        private void RemoveByValusInDoubleLinkedList(int value, bool allOrOne = true)
        {
            if (!NeedToDelete()) return;

            DoubleLink current = _root;
            for (int index = 0; index < Length; index++)
            {
                if (current.Value == value)
                {
                    if (index == 0)
                    {
                        RemoveValueInStartInList();
                    }
                    else if (index == Length - 1)
                    {
                        RemoveValueInEndInList();
                        break;
                    }
                    else
                    {
                        RemoveGivenQuantityOfValuesByIndexInList(index);
                    }
                    if (AllOrOneValue(allOrOne))
                    {
                        current = current.LinkNext;
                        index--;
                        continue;
                    }
                    break;
                }
                current = current.LinkNext;
            }
        }

        private bool NeedToDelete()
        {
            if (Length == 0) return false;
            return true;
        }

        private bool AllOrOneValue(bool allOrOne)
        {
            if (allOrOne) return true;
            return false;
        }

        // 24. Добавление списка в конец
        public void AddNewListToEndList(DoubleLinkedList addArray)
        {
            DoubleLinkedList copyList = CopyDoubleLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                _tail.LinkNext = copyList._root;
                _tail = copyList._tail;
            }
            else
            {
                if (Length == 0)
                {
                    _root = copyList._root;
                    _tail = copyList._tail;
                }
            }
            Length += copyList.Length;
        }

        // 25. Добавление списка в начало
        public void AddNewListToBeginList(DoubleLinkedList addArray)
        {
            DoubleLinkedList copyList = CopyDoubleLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                copyList._tail.LinkNext = _root;
                _root = copyList._root;
            }
            else
            {
                if (Length == 0)
                {
                    _root = copyList._root;
                    _tail = copyList._tail;
                }
            }
            Length += copyList.Length;
        }

        // 26. Добавление списка по индексу
        public void AddNewListByIndexInList(DoubleLinkedList addArray, int index)
        {
            Exceptions.CheckExceptionIndex(index,Length);

            if (index == 0 || index == Length)
            {
                if (index == 0)
                {
                    AddNewListToBeginList(addArray);
                }
                else
                {
                    AddNewListToEndList(addArray);
                }
                return;
            }

           DoubleLinkedList copyList = CopyDoubleLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                DoubleLink tmp = GetNodeByIndex(index - 1);
                copyList._tail.LinkNext = tmp.LinkNext;
                tmp.LinkNext = copyList._root;
            }
            else
            {
                if (Length == 0)
                {
                    _root = copyList._root;
                    _tail = copyList._tail;
                }
            }
            Length += copyList.Length;
        }

        public DoubleLinkedList CopyDoubleLinkedList(DoubleLinkedList list)
        {
            DoubleLinkedList newList = new DoubleLinkedList();
            if (list.Length != 0)
            {
                DoubleLink current;
                current = list._root;
                for (int i = 0; i < list.Length; i++)
                {
                    newList.AddValueLastInList(current.Value);
                    current = current.LinkNext;
                }
            }
            else
            {
                newList = new DoubleLinkedList();
            }
            return newList;
        }

        public override string ToString()
        {
            string s = string.Empty;
            if (Length != 0)
            {
                DoubleLink current = _root;
                while (!(current.LinkNext is null))
                {
                    s += current.Value + " ";
                    current = current.LinkNext;
                }
                s += current.Value + " ";
            }

            return s;
        }

        public override bool Equals(object obj)
        {
            DoubleLinkedList list = (DoubleLinkedList)obj;
            if (this.Length != list.Length)
            {
                return false;
            }
            if (this.Length == 0)
            {
                return true;
            }
            if (this._tail.Value != list._tail.Value)
            {
                return false;
            }
            if (!(this._tail.LinkNext is null) || !(list._tail.LinkNext is null))
            {
                return false;
            }
            DoubleLink currentThis = this._root;
            DoubleLink currentList = list._root;

            while (!(currentThis.LinkNext is null))
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.LinkNext;
                currentThis = currentThis.LinkNext;
            }
            if (currentThis.Value != currentList.Value)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }       


        public DoubleLink GetNodeByIndex(int index)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            DoubleLink current = _root;
            if (index == Length - 1)
            {
                current = _tail;
            }
            else
            {
                for (int i = 1; i <= index; i++)
                {
                    current = current.LinkNext;
                }
            }
            return current;
        }
    }
}
