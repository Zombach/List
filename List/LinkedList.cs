using System;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }

        private LinkNode _root;
        private LinkNode _tail;
        

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
            _root = new LinkNode(value);
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
                _tail.LinkNext = new LinkNode(value);
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
            LinkNode _new = new LinkNode(value);
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
            LinkNode _current = GetNodeByIndex(index - 1);
            LinkNode _new = new LinkNode(value);
            _new.LinkNext = _current.LinkNext;
            _current.LinkNext = _new;
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
            if (Length > 1)
            {
                LinkNode _current = GetNodeByIndex(Length - 2);
                _current.LinkNext = null;
                _tail = _current;
                Length--;                
            }
            else
            {
                _root = null;
                Length = 0;
            }
            
        }

        // 5. Удаление из начала одного элемента
        public void RemoveValueInStartInLinkedList()
        {
            RemoveGivenQuantityOfValuesByIndexInLinkedList(0);
        }

        // 6. Удаление по индексу одного элемента
        public void RemoveValueByIndexInLinkedList(int index)
        {
            RemoveGivenQuantityOfValuesByIndexInLinkedList(index);
        }

        // 7. Удаление из конца N элементов
        public void RemoveGivenQuantityOfValuesTheEndByLinkedList(int qty)
        {
            RemoveGivenQuantityOfValuesByIndexInLinkedList(Length - 1, qty);
        }

        // 8. Удаление из начала N элементов
        public void RemoveGivenQuantityOfValuesTheStartByLinkedList(int qty)
        {
            RemoveGivenQuantityOfValuesByIndexInLinkedList(0, qty);
        }

        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInLinkedList(int index, int qty = 1)
        {
            LinkNode _current = _root;
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
                _current = _root;
                for (int j = 0; j < Length - 1 - qty; j++)
                {
                    _current = _current.LinkNext;
                }
                _current.LinkNext = null;
                _tail = _current;
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
                                _current.LinkNext = _current.LinkNext.LinkNext;
                            }
                        }                        
                        else
                        {
                            _current.LinkNext = null;                            
                        }
                        if (_current.LinkNext == null)
                        {
                            _tail = _current;
                        }
                        break;
                    }
                    _current = _current.LinkNext;
                    count++;
                }
            }
            Length -= qty;
        }

        // 12. Первый индекс по значению
        public int GetFirstIndexByValue(int value)
        {
            LinkNode _current = _root;
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value == value)
                {
                    index = i;
                    break;
                }
                _current = _current.LinkNext;
            }
            return index;
        }

        // 13. Изменение по индексу
        public void ChangeValueByIndex(int index, int value)
        {
            LinkNode _current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (i == index)
                {
                    _current.Value = value;
                    break;
                }
                _current = _current.LinkNext;
            }
        }

        // 14. Реверс (123 -> 321)
        public void ReversLinkedList()
        {
            //_tail = _root;
            //LinkNode counter = _root;
            //for(int i = 0; i < Length - 1; i++)
            //{
            //    _current = _current.LinkNext;
            //    _current = counter;
            //    _current.LinkNext = _root;
            //    _root = _current;
            //}
        }

        // 15. Поиск значения максимального элемента
        public int FindMaxValueByLinkedList()
        {
            LinkNode _current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value < _root.Value)
                {
                    _current.Value = _root.Value;
                }
                _root = _root.LinkNext;
            }
            return _current.Value;
        }

        // 16. Поиск значения минимального элемента
        public int FindMinValueByLinkedList()
        {
            LinkNode _current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value > _root.Value)
                {
                    _current.Value = _root.Value;
                }
                _root = _root.LinkNext;
            }
            return _current.Value;
        }

        // 17. Поиск индекс максимального элемента
        public int FindIndexMaxValueByLinkedList()
        {
            LinkNode _current = _root;
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value < _root.Value)
                {
                    index = i;
                }
                _root = _root.LinkNext;
            }
            return index;
        }

        // 18. Поиск индекс минимального элемента
        public int FindIndexMinValueByLinkedList()
        {
            LinkNode _current = _root;
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value > _root.Value)
                {
                    index = i;
                }
                _root = _root.LinkNext;
            }
            return index;
        }

        // 19. Сортировка по возрастанию
        public void SortAscending()
        {
            if (Length <= 1)
            {
                return;
            }
            for(LinkNode _current = _root; _current.LinkNext != null; _current = _current.LinkNext)
            {
                for (LinkNode minNode = _current; minNode.LinkNext != null; minNode = minNode.LinkNext)
                {
                    if (_current.Value > minNode.Value || _current.Value > _tail.Value)
                    {
                        if (_current.Value > minNode.Value)
                        {
                            int tmp = minNode.Value;
                            minNode.Value = _current.Value;
                            _current.Value = tmp;
                        }
                        if (_current.Value > _tail.Value)
                        {
                            int tmp = _tail.Value;
                            _tail.Value = _current.Value;
                            _current.Value = tmp;
                        }
                    }
                }
            }
        }

        // 20. Сортировка по убыванию
        public void SortDescending()
        {
            
        }

        // 21. Удаление по значению первого
        public void RemoveByValueFirstMatchInLinkedList(int value)
        {
            LinkNode _current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value == value)
                {
                    _current.LinkNext = _current.LinkNext.LinkNext;
                    break; 
                }
                _current = _current.LinkNext;
            }
        }

        // 22. Удаление по значению всех
        public void RemoveByValueAllMatchInLinkedList(int value)
        {
            LinkNode _current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (_current.Value == value)
                {
                    _current.LinkNext = _current.LinkNext.LinkNext;
                }
                _current = _current.LinkNext;
            }
        }

        // 24. Добавление списка в конец
        public LinkedList AddNewListToEndLinkedList(LinkedList array, LinkedList addArray)
        {
            if( array.Length != 0 && addArray.Length !=0)
            {
                array._tail.LinkNext = addArray._root;
                array._tail = addArray._tail;
                array.Length += addArray.Length;
            }
            else
            {
                if (array.Length == 0)
                {
                    array = addArray;
                }
            }
                
            return array;
        }

        // 25. Добавление списка в начало
        public LinkedList AddNewListToBeginLinkedList(LinkedList array, LinkedList addArray)
        {
            LinkedList tmp = array;
            array = addArray;
            addArray = tmp;
            tmp = AddNewListToEndLinkedList(array, addArray);
            return tmp;
        }

        // 26. Добавление списка по индексу
        public void AddNewListByIndexInLinkedList()
        {

        }

        public override string ToString()
        {
            string s = string.Empty;
            if (Length != 0)
            {
                LinkNode current = _root;
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
            LinkNode currentThis = this._root;
            LinkNode currentList = list._root;

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

        public LinkNode GetNodeByIndex(int index)
        {
            CheckExceptionIndex(index);
            LinkNode _current = _root;
            if (index == Length - 1)
            {
                _current = _tail;
            }
            else
            {
                for(int i = 1; i <= index; i++)
                {
                    _current = _current.LinkNext;
                }
            }
            return _current;
        }
    }
}
