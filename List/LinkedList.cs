using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return 0;
            }
            set
            {

            }
        }

        // 23.1 3 конструктора (пустой)  
        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
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
                for (int i = 0; i < values.Length; i++)
                {
                    if (Length == 0)
                    {
                        _root = new LinkNode(values[i]);
                        _tail = _root;
                    }
                    else
                    {
                        _tail.LinkNext = new LinkNode(values[i]);
                        _tail = _tail.LinkNext;
                    }
                    Length++;
                }
            }
        }

        // 1. Добавление значения в конец
        public void AddValueLastInLinkedList(int value)
        {
            AddValueByIndexInLinkedList(value, Length);
        }

        // 2. Добавление значения в начало
        public void AddValueByFirstInLinkedList(int value)
        {
            AddValueByIndexInLinkedList(value, 0);
        }

        // 3. Добавление значения по индексу
        public void AddValueByIndexInLinkedList(int value, int index)
        {
            if (Length == 0 || index == 0)
            {
                LinkNode newNode = new LinkNode(value);
                if (Length == 0)
                {
                    _root = newNode;
                    _tail = _root;
                }
                else
                {
                    newNode.LinkNext = _root;
                    _root = newNode;
                }
                Length++;
                return;
            }
            else if (Length == index)
            {
                _tail.LinkNext = new LinkNode(value);
                _tail = _tail.LinkNext;
                Length++;
                return;
            }
            else
            {
                int count = 0;
                LinkNode current = _root;
                LinkNode addNode = new LinkNode(value);
                for(int i = 1; i < Length; i++)
                {
                    if (count == index - 1)
                    {
                        addNode.LinkNext = current.LinkNext;
                        current.LinkNext = addNode;
                        Length++;
                    }
                    current = current.LinkNext;
                    count++;                    
                }
            }
        }

        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInLinkedList()
        {
            RemoveGivenQuantityOfValuesByIndexInLinkedList(Length - 1);
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
            int count = 0;
            LinkNode currentNode = _root;
            if (index == 0)
            {
                for (int i = 0; i < qty; i++)
                {
                    _root = _root.LinkNext;
                }
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
                                currentNode.LinkNext = currentNode.LinkNext.LinkNext;
                            }
                        }
                        else
                        {
                            currentNode.LinkNext = null;                            
                        }
                        if (currentNode.LinkNext == null)
                        {
                            _tail = currentNode;
                        }
                        break;
                    }
                    currentNode = currentNode.LinkNext;
                    count++;
                }
            }
            Length -= qty;
        }

        // 12. Первый индекс по значению
        public void GetFirstIndexByValue()
        {
           
        }

        // 13. Изменение по индексу
        public void ChangeValueByIndex()
        {
            
        }

        // 14. Реверс (123 -> 321)
        public void ReversLinkedList()
        {
            
        }

        // 15. Поиск значения максимального элемента
        public void FindMaxValueByLinkedList()
        {
            
        }

        // 16. Поиск значения минимального элемента
        public void FindMinValueByLinkedList()
        {
            
        }

        // 17. Поиск индекс максимального элемента
        public void FindIndexMaxValueByLinkedList()
        {
            
        }

        // 17. Поиск индекс минимального элемента
        public void FindIndexMinValueByLinkedList()
        {
            
        }

        // 19. Сортировка по возрастанию
        public void SortAscending()
        {
            
        }

        // 20. Сортировка по убыванию
        public void SortDescending()
        {
            
        }

        // 21. Удаление по значению первого
        public void RemoveByValueFirstMatchInLinkedList()
        {
            
        }

        // 22. Удаление по значению всех(?вернуть кол-во)
        public void RemoveByValueAllMatchInLinkedList()
        {
            
        }

        // 24. Добавление списка в конец
        public void AddNewListToEndLinkedList()
        {
            
        }

        // 25. Добавление списка в начало
        public void AddNewListToBeginLinkedList()
        {
            
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
    }
}
