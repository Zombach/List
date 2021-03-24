using System;

namespace List
{
    public class ArrayList
    {
        public int Length { set; private get; }

        private int[] _list;

        public int index
        {
            set
            {

            }
            get
            {
                return index;
            }
        }

        public ArrayList()
        {
            Length = 0;
            _list = new int[10];
        }
        public ArrayList(int value)
        {
            Length = 1;
            _list = new int[10];
            _list[0] = value;
        }
        public ArrayList(int[] list)
        {
            _list = list;
            Length = _list.Length;
        }

        public void AddValueByLast(int value)
        {
            CheckUpSize();
            _list[Length] = value;
            Length++;
        }
        public void AddValueByFirst(int value)
        {
            CheckUpSize();
            for (int i = 0; i<Length; i++)
            {
                _list[i + 1] = _list[i];
            }
            _list[0] = value;
            Length++;
        }
        public void AddValueByIndex(int value, int index)
        {
            CheckUpSize();
            for (int i = Length; i > index; i--)
            {
                _list[i] = _list[i - 1];
            }
            _list[index] = value;
            Length++;
        }

        public void RemoveLastValue()
        {
            checkDownSize();
        }
        public void RemoveFirstValue(int n = 1)
        {
            for (int i = n; i < Length; i++)
            {
                _list[i] = _list[i - 1];
            }
            checkDownSize();
        }
        public void RemoveIndexValue(int index, int n = 1)
        {
            for (int i = index; i < Length - n; i++)
            {
                _list[i] = _list[i + n];
            }
            checkDownSize(n);
        }

        public void RemoveLastN_Values(int n)
        {
            checkDownSize(n);
        }        
        public void RemoveFirstN_Values(int n)
        {
            RemoveFirstValue(n);
        }
        public void RemoveIndexN_Values(int index, int n)
        {
            RemoveIndexValue(index, n);
        }
        public int ReturnByIndex(int index)
        {
          return _list[index];
        }

        public int ReturnFirstIndexByValue(int value)
        {
            for (int index = 0; index < Length; index++)
            {
                if (_list[index] == value)
                {
                    return index;
                }
            }
            return value;
        }
        public void ChangeValueByIndex(int index,int value)
        {
            _list[index] = value;                  
        }
        private void CheckUpSize()
        {
            if (Length == _list.Length)
            {
                UpSize();
            }
        }
        private void checkDownSize(int n = 1)
        {
            Length -= n;
            if (Length < (_list.Length/ 2))
            {
                DownSize();
            }
        }
        private void UpSize()
        {
            int newLength = (int)(_list.Length * 1.33d + 1);
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