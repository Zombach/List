using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class LinkedList
    {
        public int Length { get; private set; }

        private Node _root;
        private Node _tail;

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
            _root = new Node(value);
            _tail = _root;
        }

        // 23.3 3 конструктора (на основе массива )
        public LinkedList(int[] values)
        {
            if (values.Length != 0)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    Add(values[i]);
                }
            }
        }

        public void Add(int value)
        {
            if (Length == 0)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }

            Length++;
        }


        // 1. Добавление значения в конец
        public void AddValueLastInLinkedList()
        {
            
        }

        // 2. Добавление значения в начало
        public void AddValueByFirstInLinkedList()
        {
            
        }

        // 3. Добавление значения по индексу
        public void AddValueByIndexInLinkedList()
        {
            
        }

        // 4. Удаление из конца одного элемента
        public void RemoveValueInEndInLinkedList()
        {
            
        }

        // 5. Удаление из начала одного элемента
        public void RemoveValueInStartInLinkedList()
        {
            
        }

        // 6. Удаление по индексу одного элемента
        public void RemoveValueByIndexInLinkedList()
        {
            
        }

        // 7. Удаление из конца N элементов
        public void RemoveGivenQuantityOfValuesTheEndByLinkedList()
        {
            
        }

        // 8. Удаление из начала N элементов
        public void RemoveGivenQuantityOfValuesTheStartByLinkedList()
        {
            
        }

        // 9. Удаление по индексу N элементов
        public void RemoveGivenQuantityOfValuesByIndexInLinkedList()
        {
            
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
    }
}
