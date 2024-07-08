using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class phoneBook
    {
        private int size;
        private string[] names;
        private long[] numbers;

        public int Size
        {
            get
            {
                return size;
            }
            private set
            {
                size = value;
            }
        }

        public phoneBook()
        {
            size = 0;
            names = new string[size];
            numbers = new long[size];
        }
        public phoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        public long GetNumber(string _name)
        {
            if (names != null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == _name)
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }
        public long SetNumber(string _name, long _number)
        {
            if (names != null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == _name)
                    {
                        numbers[i] = _number;
                        break;
                    }
                }
            }
            return -1;
        }
        public void addPerson(int index, string _name, long _number)
        {
            if (names is not null && numbers is not null)
            {
                if (index >= 0 && index < size)
                {
                    names[index] = _name;
                    numbers[index] = _number;
                }
            }
        }

        public long this[string _name]
        {
            get
            {
                if (names != null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (names[i] == _name)
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names != null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (names[i] == _name)
                        {
                            numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        }
        public string this[int _index]
        {
            get
            {

                return $"{names[_index]} , {numbers[_index]}";
            }
        }
    }
}
