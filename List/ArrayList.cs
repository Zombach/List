using System;

namespace List
{
    public class ArrayList
    {
        public int Length { set; private get; }

        private int[] _list;

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
            checkUpSize();
            _list[Length] = value;
            Length++;
        }
        public void AddValueByFirst(int value)
        {
            checkUpSize();
            for (int i = 0; i<Length; i++)
            {
                _list[i + 1] = _list[i];
            }
            _list[0] = value;
            Length++;
        }
        public void AddValueByIndex(int value, int index)
        {
            checkUpSize();
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
            Length--;
        }
        public void RemoveFirstValue()
        {
            for (int i = 1; i < Length; i++)
            {
                _list[i] = _list[i - 1];
            }
            checkDownSize();
        }
        public void RemoveIndexValue(int index)
        {
            for (int i = index; i < Length - 1; i++)
            {
                _list[i] = _list[i + 1];
            }
            checkDownSize();
        }
        private void checkUpSize()
        {
            if (Length == _list.Length)
            {
                UpSize();
            }
        }
        private void checkDownSize()
        {
            Length--;
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