using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp70
{
    public class MyString : IComparable<MyString>
    {
        private char[] _charArray;

        public MyString(string otherString)
        {
            _charArray = otherString.ToCharArray();
        }
        public MyString(char[] array)
        {
            _charArray = array;
        }

        public int Length => _charArray.Length;

        public MyString Concat (MyString otherString)
        {
            if (_charArray.Length == 0)
                throw new ArgumentOutOfRangeException();

            var temp = new char[_charArray.Length + otherString.Length];

            for(int i = 0; i < _charArray.Length; i++)
            {
                temp[i] = _charArray[i]; 
            }
            for (int i = _charArray.Length; i < temp.Length; i++)
            {
                temp[i] = _charArray[i - _charArray.Length];
            }

            return new MyString(temp);
        }


        public char[] ToCharArray(MyString str)
        {
            var temp = new char[_charArray.Length];
            for (int i = 0; i < _charArray.Length; i++)
            {
                temp[i] = _charArray[i];
            }
            return temp;
        }

        public int CompareTo(MyString other)
        {
            if (_charArray.Length > other.Length)
                return 1;

            if (_charArray.Length < other.Length)
                return -1;

            else return 0;
        }

        public char this[int index]
        {
            get { return _charArray[index]; }
            set { _charArray[index] = value; }
        }
        public static MyString operator +(MyString str, MyString otherString)
        {
            return str.Concat(otherString);
        }

        public static MyString operator +(MyString str, string otherString)
        {
            return str.Concat(new MyString(otherString));
        }
        public static MyString operator +(string otherString, MyString str)
        {
            return new MyString(otherString).Concat(str);
        }

        public static MyString operator +(char charSymbol, MyString str)
        {
            return new MyString(charSymbol.ToString()).Concat(str);
        }
        public static MyString operator +(MyString str, char charSymbol)
        {
            return str.Concat(new MyString(charSymbol.ToString()));
        }

    }
}
