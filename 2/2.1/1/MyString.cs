using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp70
{
    public class MyString : IComparable<MyString>
    {
        private char[] charArray;

        public MyString(string otherString)
        {
            charArray = otherString.ToCharArray();
        }
        
        public int Lenght { get => charArray.Length; }

        public MyString Concat (MyString otherString)
        {
            if (charArray.Length == 0)
                throw new ArgumentOutOfRangeException();

            var temp = new char[charArray.Length + otherString.Lenght];

            for(int i = 0; i < charArray.Length; i++)
            {
                temp[i] = charArray[i]; 
            }
            for (int i = charArray.Length; i < temp.Length; i++)
            {
                temp[i] = charArray[i - charArray.Length];
            }

            return ToMyString(temp);
        }


        public char[] ToCharArray(MyString str)
        {
            return charArray;
        }

        public static MyString ToMyString(char[] array)
        {
            return new MyString(array.ToString());
        }

        public int CompareTo(MyString other)
        {
            if (charArray.Length > other.Lenght)
                return 1;

            if (charArray.Length < other.Lenght)
                return -1;

            else return 0;
        }

        public char this[int index]
        {
            get { return charArray[index]; }
            set { charArray[index] = value; }
        }
        public static MyString operator +(MyString str, MyString otherString)
        {
            return str.Concat(otherString);
        }

    }
}
