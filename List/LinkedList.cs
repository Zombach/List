using System;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }

        private Link _root;
        private Link _tail;        

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
        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = _root;
        }

        // 23.2 3 конструктора (на основе одного элемента)
        public LinkedList(int value)
        {
            Length = 1;
            _root = new Link(value);
            _tail = _root;
        }

        // 23.3 3 конструктора (на основе массива )
        public LinkedList(int[] values)
        {
            if (values.Length != 0)
            {
                if (Length == 0)
                {
                    AddValueByFirstInLinkedList(values[0]);
                }
                for (int i = 1; i < values.Length; i++)
                {
                    AddValueLastInLinkedList(values[i]);                    
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
        public void AddValueLastInLinkedList(int value)
        {
            if (Length != 0)
            {
                _tail.LinkNext = new Link(value);
                _tail = _tail.LinkNext;
                Length++;
            }
            else
            {
                AddValueByFirstInLinkedList(value);
            }
        }

        // 2. Добавление значения в начало
        public void AddValueByFirstInLinkedList(int value)
        {
            Link _new = new Link(value);
            if (Length != 0)
            {
                _new.LinkNext = _root;
                _root = _new;
            }
            else
            {
                _root = _new;
                _tail = _root;
            }
            Length++;
        }

        // 3. Добавление значения по индексу
        public void AddValueByIndexInLinkedList(int value, int index)
        {
            CheckExceptionIndex(index);            
            if (NodeBegin(value, index) || NodeLast(value, index))
            {
                return;
            }
            Link current = GetNodeByIndex(index - 1);
            Link _new = new Link(value);
            _new.LinkNext = current.LinkNext;
            current.LinkNext = _new;
            Length++;
        }

        
        private bool NodeBegin(int value, int index)
        {
            bool check = false;
            if (index == 0)
            {
                AddValueByFirstInLinkedList(value);
                check = true;
            }
            return check;
        }

        private bool NodeLast(int value, int index)
        {
            bool check = false;
            if (index == Length)
            {
                AddValueLastInLinkedList(value);
                check = true;
            }
            return check;
        }


        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInLinkedList()
        {
            RemoveGivenQuantityOfValuesTheEndByLinkedList();
        }

        // 5. Удаление из начала одного элемента
        public void RemoveValueInStartInLinkedList()
        {
            RemoveGivenQuantityOfValuesTheStartByLinkedList();
        }

        // 6. Удаление по индексу одного элемента
        public void RemoveValueByIndexInLinkedList(int index)
        {
            RemoveGivenQuantityOfValuesByIndexInLinkedList(index);
        }

        // 7. Удаление из конца N элементов
        public void RemoveGivenQuantityOfValuesTheEndByLinkedList(int qty = 1)
        {
            Link current = _root;
            int count = Length - 1 - qty;
            if (Length != 0)
            {
                if(count > 0)
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
        public void RemoveGivenQuantityOfValuesTheStartByLinkedList(int qty = 1)
        {
            if (Length != 0)
            {
                for (int i = 0; i < qty; i++)
                {
                    if (Length > 1) _root = _root.LinkNext;
                    else
                    {
                        _root = null;
                        _tail = null;
                        Length--;
                        break;
                    }
                    Length--;
                }
            }
            else
            {
                return; // ошибку?
            }
        }            

        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInLinkedList(int index, int qty = 1)
        {
            Link current = _root;
            if (index == 0)
            {
                RemoveGivenQuantityOfValuesTheStartByLinkedList(qty);
            }
            else if (index == Length - 1)
            {
                RemoveGivenQuantityOfValuesTheEndByLinkedList();
            }
            else
            {
                current = GetNodeByIndex(index - 1);
                Link currentNext = GetNodeByIndex(index + qty);
                if (index + qty >= Length - 1)
                {
                    current.LinkNext = currentNext;
                    Length -= qty;
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
            Link current = _root;
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
            Link current = _root;
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
        public void ReversLinkedList()
        {
                if (Length > 1)
                {
                    _tail = _root;
                    Link previous = null;
                    Link next = _root.LinkNext;
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
        public int FindMaxValueByLinkedList()
        {
            return FindIndexMaxOrMinValueByLinkedList(maxOrMin: true, value: true);
        }

        // 16. Поиск значения минимального элемента
        public int FindMinValueByLinkedList()
        {
            return FindIndexMaxOrMinValueByLinkedList(maxOrMin: false, value: true);
        }

        // 17. Поиск индекс максимального элемента
        public int FindIndexMaxValueByLinkedList()
        {            
            return FindIndexMaxOrMinValueByLinkedList(maxOrMin: true);
        }

        // 18. Поиск индекс минимального элемента
        public int FindIndexMinValueByLinkedList()
        {
            return FindIndexMaxOrMinValueByLinkedList(maxOrMin :false);
        }

        private int FindIndexMaxOrMinValueByLinkedList(bool maxOrMin = true, bool value = false)
        {
            CheckNullReferenceException();
            Link current = _root;
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

        public bool FindMaxOrMin(Link current, bool maxOrMin)
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
            Link temp = _tail;
            for (Link current = _root; temp.LinkNext != _root.LinkNext;)
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
        private bool SortAscendingOrDescending(Link temp, Link current, bool ascendingOrDescending)
        {
            if (ascendingOrDescending && temp.Value < current.Value || !ascendingOrDescending && temp.Value > current.Value)
            {
                return true;
            }
            return false;
        }

        // 21. Удаление по значению первого
        public void RemoveByValueFirstMatchInLinkedList(int value)
        {
            RemoveByValusInLinkedList(value, false);
        }

        // 22. Удаление по значению всех
        public void RemoveByValueAllMatchInLinkedList(int value)
        {
            RemoveByValusInLinkedList(value);
        }

        private void RemoveByValusInLinkedList(int value, bool allOrOne = true)
        {
            if (!NeedToDelete()) return;

            Link current = _root;
            for (int index = 0; index < Length; index++)
            {
                if (current.Value == value)
                {
                    if (index == 0)
                    {
                        RemoveValueInStartInLinkedList();
                    }
                    else if (index == Length - 1)
                    {
                        RemoveValueInEndInLinkedList();
                        break;
                    }
                    else
                    {
                        RemoveGivenQuantityOfValuesByIndexInLinkedList(index);                        
                    }

                    if (allOrOne)
                    {
                        if (Length > 0)
                        {
                            index--;
                            continue;
                        }
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
                

        // 24. Добавление списка в конец
        public void AddNewListToEndLinkedList(LinkedList addArray)
        {
            LinkedList copyList = CopyLinkedList(addArray);
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
        public void AddNewListToBeginLinkedList(LinkedList addArray)
        {
            LinkedList copyList = CopyLinkedList(addArray);
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
        public void AddNewListByIndexInLinkedList(LinkedList addArray, int index)
        {
            CheckExceptionIndex(index);

            if (index == 0 || index == Length)
            {
                if (index == 0)
                {
                    AddNewListToBeginLinkedList(addArray);
                }
                else
                {
                    AddNewListToEndLinkedList(addArray);
                }
                return;
            }

            LinkedList copyList = CopyLinkedList(addArray);
            if (Length != 0 && addArray.Length != 0)
            {
                Link tmp = GetNodeByIndex(index - 1);
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

        public LinkedList CopyLinkedList(LinkedList list)
        {
            LinkedList newList = new LinkedList();
            if (list.Length != 0)
            {
                Link current;
                current = list._root;
                for (int i = 0; i < list.Length; i++)
                {
                    newList.AddValueLastInLinkedList(current.Value);
                    current = current.LinkNext;
                }
            }
            else
            {
                newList = new LinkedList();
            }
            return newList;
        }

        public override string ToString()
        {
            string s = string.Empty;
            if (Length != 0)
            {
                Link current = _root;
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
            LinkedList list = (LinkedList)obj;
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
            Link currentThis = this._root;
            Link currentList = list._root;

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


        public void CheckExceptionIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void CheckNullReferenceException()
        {
            if (Length == 0)
            {
                throw new NullReferenceException();
            }
        }
        

        public Link GetNodeByIndex(int index)
        {
            CheckExceptionIndex(index);
            Link current = _root;
            if (index == Length - 1)
            {
                current = _tail;
            }
            else
            {
                for(int i = 1; i <= index; i++)
                {
                    current = current.LinkNext;
                }
            }
            return current;
        }
    }
}
