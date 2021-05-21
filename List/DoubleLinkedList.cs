using System;
using List.Node;

namespace List
{
    public class DoubleLinkedList : IList
    {
        private DoubleLink _root;
        private DoubleLink _tail;
     
        public int Length { get; private set; }

        public int this[int index]
        {
            get => GetNodeByIndex(index).Value;
            set => GetNodeByIndex(index).Value = value;
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
            DoubleLink newLink = new DoubleLink(value);
            if (Length != 0)
            {
                _tail.LinkNext = newLink;
                newLink.LinkPrevious = _tail;
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
            DoubleLink newLink = new DoubleLink(value);
            if (Length != 0)
            {
                newLink.LinkNext = _root;
                _root.LinkPrevious = newLink;
                _root = newLink;
            }
            else
            {
                _root = newLink;
                _tail = _root;
            }
            Length++;
        }

        // 3. Добавление значения по индексу
        public void AddValueByIndexInList(int index, int value)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            if (NodeBegin(value, index) || NodeLast(value, index))
            {
                return;
            }
            DoubleLink current = GetNodeByIndex(index - 1);
            DoubleLink newLink = new DoubleLink(value)
            {
                LinkNext = current.LinkNext,
                LinkPrevious = current
            };
            newLink.LinkNext.LinkPrevious = newLink;
            current.LinkNext = newLink;

            
            current.LinkNext = newLink;
            Length++;
        }

        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInList()
        {
            RemoveGivenQuantityOfValuesTheEndByList();
        }

        // 5. Удаление из начала одного элемента
        public void RemoveValueInStartInList()
        {
            RemoveGivenQuantityOfValuesTheStartByList();
        }

        // 6. Удаление по индексу одного элемента
        public void RemoveValueByIndexInList(int index)
        {
            RemoveGivenQuantityOfValuesByIndexInList(index);
        }

        // 7. Удаление из конца N элементов
        public void RemoveGivenQuantityOfValuesTheEndByList(int qty = 1)
        {
            Exceptions.CheckExceptionByCountToRemove(qty);
            Exceptions.CheckExceptionByCountToRemoveInLast(Length, qty);
            DoubleLink current = _root;
            int count = Length - 1 - qty;
            if (Length != 0)
            {
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        current = current.LinkNext;
                    }
                    current.LinkNext = null;
                    _tail = current;
                    Length -= qty;
                }
                else
                {
                    _root = null;
                    _tail = null;
                    Length = 0;
                }
            }
        }

        // 8. Удаление из начала N элементов
        public void RemoveGivenQuantityOfValuesTheStartByList(int count = 1)
        {
            Exceptions.CheckExceptionByCountToRemove(count);
            Exceptions.CheckExceptionByCountToRemoveInLast(Length, count);
            if (Length != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Length--;

                    if (Length > 1)
                    {
                        _root = _root.LinkNext;
                        _root.LinkPrevious = null;
                    }
                    else
                    {
                        _root = null;
                        _tail = null;

                        break;
                    }
                }
            }
            else
            {
                Exceptions.CheckNullReferenceException(Length);
            }
        }

        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInList(int index, int count = 1)
        {
            Exceptions.CheckExceptionByCountToRemove(count);
            Exceptions.CheckExceptionByCountToRemoveInLast(Length, count);
            Exceptions.CheckExceptionIndex(index, Length);
            if (index == 0)
            {
                RemoveGivenQuantityOfValuesTheStartByList(count);
            }
            else if (index == Length - 1)
            {
                RemoveGivenQuantityOfValuesTheEndByList();
            }
            else
            {
                DoubleLink current = GetNodeByIndex(index - 1);
                if (index + count < Length)
                {
                    DoubleLink currentNext = GetNodeByIndex(index + count);
                    current.LinkNext = currentNext;
                    currentNext.LinkPrevious = current;
                    Length -= count;
                }
                else
                {
                    current.LinkNext = null;
                    _tail = current;
                    Length = index;
                }
            }
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
            Exceptions.CheckExceptionIndex(index + 1, Length);
            DoubleLink current;
            if (index <= Length / 2)
            {
                current = _root;
                for (int i = 0; i < Length; i++)
                {
                    if (i == index)
                    {
                        break;
                    }
                    current = current.LinkNext;
                }
            }
            else
            {
                current = _tail;
                for (int i = Length - 1; i >= 0; i--)
                {
                    if (i == index)
                    {
                        break;
                    }
                    current = current.LinkPrevious;
                }
            }
            current.Value = value;
        }

        // 14. Реверс (123 -> 321)  ///переделать
        public void ReversList()
        {
            if (Length > 1)
            {
                DoubleLink tmp = new DoubleLink();
                DoubleLink current = _root;
                _root = _tail;
                _tail = current;
                for (int i = 0; i < Length; i++)
                {
                    tmp.LinkNext = current.LinkNext;
                    current.LinkNext = current.LinkPrevious;
                    current.LinkPrevious = tmp.LinkNext;
                    current = tmp.LinkNext;
                }
            }
        }

        // 15. Поиск значения максимального элемента
        public int FindMaxValueByList()
        {
            return FindIndexMaxOrMinValueByList(maxOrMin: true, value: true);
        }

        // 16. Поиск значения минимального элемента
        public int FindMinValueByList()
        {
            return FindIndexMaxOrMinValueByList(maxOrMin: false, value: true);
        }

        // 17. Поиск индекс максимального элемента
        public int FindIndexMaxValueByList()
        {
            return FindIndexMaxOrMinValueByList(maxOrMin: true);
        }

        // 18. Поиск индекс минимального элемента
        public int FindIndexMinValueByList()
        {
            return FindIndexMaxOrMinValueByList(maxOrMin: false);
        }

        private int FindIndexMaxOrMinValueByList(bool maxOrMin = true, bool value = false)
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

        private bool FindMaxOrMin(DoubleLink current, bool maxOrMin)
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
            SortingList();
        }

        // 20. Сортировка по убыванию
        public void SortDescending()
        {
            SortingList(false);
        }


        // 21. Удаление по значению первого
        public int RemoveByValueFirstMatchInList(int value)
        {
            return RemoveByValuesInDoubleLinkedList(value, true);
        }

        // 22. Удаление по значению всех
        public int RemoveByValueAllMatchInList(int value)
        {
            return RemoveByValuesInDoubleLinkedList(value);
        }

        private int RemoveByValuesInDoubleLinkedList(int value, bool oneElement = false)
        {
            if (!NeedToDelete()) return -1;
            int count = 0;
            int index = -1;
            DoubleLink current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    if (i == 0)
                    {
                        RemoveValueInStartInList();
                    }
                    else if (i == Length - 1)
                    {
                        RemoveValueInEndInList();
                        if (oneElement)
                        {
                            index = i;
                        }
                        else
                        {
                            count++;
                        }
                        break;
                    }
                    else
                    {
                        RemoveGivenQuantityOfValuesByIndexInList(i);
                    }

                    if (oneElement)
                    {
                        index = i;
                        break;
                    }
                    i--;
                    count++;
                }
                current = current.LinkNext;
            }
            if (oneElement)
            {
                return index;
            }
            return count;
        }

        // 24. Добавление списка в конец
        public void AddNewListToEndList(int[] addArray)
        {
            DoubleLinkedList copyList = CopyLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                _tail.LinkNext = copyList._root;
                copyList._root.LinkPrevious = _tail;
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
        public void AddNewListToBeginList(int[] addArray)
        {
            DoubleLinkedList copyList = CopyLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                copyList._tail.LinkNext = _root;
                _root.LinkPrevious = copyList._tail;
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
        public void AddNewListByIndexInList(int index, int[] addArray)
        {
            Exceptions.CheckExceptionIndex(index, Length);

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

            DoubleLinkedList copyList = CopyLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                DoubleLink tmp = GetNodeByIndex(index - 1);
                copyList._tail.LinkNext = tmp.LinkNext;
                copyList._root.LinkPrevious = tmp;
                tmp.LinkNext.LinkPrevious = copyList._tail;
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
            if (this.Length == 0 && list.Length == 0)
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
            if (!(this._root.LinkPrevious is null) || !(list._root.LinkPrevious is null))
            {
                return false;
            }
            DoubleLink currentThis = this._root;
            DoubleLink currentList = list._root;
            do
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }

                if (currentThis.LinkPrevious == null && currentList.LinkPrevious != null
                    || currentThis.LinkPrevious != null && currentList.LinkPrevious == null)
                {
                    return false;
                }
                else if (currentThis.LinkPrevious != null && currentList.LinkPrevious != null)
                {
                    if (currentThis.LinkPrevious.Value != currentList.LinkPrevious.Value)
                    {
                        return false;
                    }
                }
                currentThis = currentThis.LinkNext;
                currentList = currentList.LinkNext;
            }
            while (!(currentThis is null));
            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }


        private DoubleLink GetNodeByIndex(int index)
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

        private DoubleLinkedList CopyLinkedList(int[] list)
        {
            DoubleLinkedList newList = new DoubleLinkedList();
            if (list.Length != 0)
            {
                DoubleLinkedList tmp = new DoubleLinkedList(list);
                DoubleLink current = tmp._root;
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

        private bool NeedToDelete()
        {
            if (Length == 0) return false;
            return true;
        }

        private void SortingList(bool ascendingOrDescending = true)
        {
            if (Length == 0) return;
            int step = 1;
            DoubleLink first;
            DoubleLink second;
            DoubleLink tmp;

            for (int group = 2; group < Length*2; group *= 2)
            {
                int groupOne = 1;
                int groupTwo = 1;
                int count = 0;
                int countFirst = 0;
                int countSecond = 0;
                int tmpCountFirst = 1;
                do
                {
                    first = _root;
                    second = _root;
                    for (int i = 0; i < group*count; i++)
                    {
                        first = first.LinkNext;
                        second = second.LinkNext;
                    }

                    for (int i = 0; i < countFirst; i++)
                    {
                        first = first.LinkNext;
                    }
                    
                    for (int i = 0; i < step + countSecond; i++)
                    {
                        second = second.LinkNext;
                    }

                    if (second == null)
                    {
                        for (int i = 0; i < tmpCountFirst; i++)
                        {
                            first = first.LinkNext;
                        }

                        if (first == null)
                        {
                            break;
                        }

                        second = first.LinkNext;
                        if (second == null)
                        {
                            tmpCountFirst++;
                            continue;
                        }
                    }

                    if (first.Value <= second.Value)
                    {
                        if (groupOne < group/2)
                        {
                            countFirst++;
                            groupOne++;
                            count--;
                        }
                        else if (groupTwo < group / 2)
                        {
                            groupTwo++;
                            count--;
                        }
                    }
                    else
                    {
                        if (first == _root)
                        {
                            _root = second;
                        }

                        if (second == _tail)
                        {
                            _tail = first;
                        }

                        int temp = 0;
                        tmp = first;
                        while (tmp != second)
                        {
                            tmp = tmp.LinkNext;
                            temp++;
                            if (temp > 2)
                            {
                                break;
                            }
                        }
                        tmp = first;
                        first = second;
                        second = tmp;



                        if (temp == 1)
                        {
                            second.LinkNext = first.LinkNext;
                            first.LinkNext = second;
                            if (second.LinkPrevious != null)
                            {
                                second.LinkPrevious.LinkNext = first;
                            }
                            first.LinkPrevious = second.LinkPrevious;
                            if (second.LinkNext != null)
                            {
                                second.LinkNext.LinkPrevious = second;
                            }
                            second.LinkPrevious = first;
                        }

                        if (temp == 2)
                        {
                            if (second.LinkNext != null)
                            {
                                second.LinkNext.LinkNext = second;
                            }
                            if (first.LinkPrevious != null)
                            {
                                first.LinkPrevious.LinkPrevious = first;
                            }

                            if (second.LinkPrevious != null)
                            {
                                second.LinkPrevious.LinkNext = first;
                            }

                            if (first.LinkNext != null)
                            {
                                first.LinkNext.LinkPrevious = second;
                            }
                            second.LinkNext = first.LinkNext;
                            first.LinkNext = first.LinkPrevious;
                            first.LinkPrevious = second.LinkPrevious;
                            second.LinkPrevious = first.LinkNext;
                        }

                        if (temp > 2)
                        {
                            if (first.LinkNext != null)
                            {
                                first.LinkNext.LinkPrevious = second;
                            }
                            if (first.LinkPrevious != null)
                            {
                                first.LinkPrevious.LinkNext = second;
                            }

                            if (second.LinkNext != null)
                            {
                                second.LinkNext.LinkPrevious = first;
                            }
                            if (second.LinkPrevious != null)
                            {
                                second.LinkPrevious.LinkNext = first;
                            }

                            second.LinkNext = first.LinkNext;

                            tmp = first;
                            do
                            {
                                tmp = tmp.LinkPrevious;
                            } 
                            while (tmp.LinkPrevious != first);
                            first.LinkNext = tmp;

                            first.LinkPrevious = second.LinkPrevious;

                            tmp = first;
                            do
                            {
                                tmp = tmp.LinkNext;
                            } 
                            while (tmp.LinkNext != second);
                            second.LinkPrevious = tmp;
                        }
                        countFirst = 0;
                        countSecond = 0;
                        groupOne = 1;
                        groupTwo = 1;
                        tmpCountFirst = 1;
                        step = 1;
                        group = 2;
                    } 
                    count++;
                } while (group != groupOne + groupTwo || count < Length/group);
                step *= 2;
            }

            if (!ascendingOrDescending)
            {
                ReversList();
            }
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
    }
}