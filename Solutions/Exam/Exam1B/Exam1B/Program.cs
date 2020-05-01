using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam1B
{
    public class Program
    {
        static void Main(string[] args) { }
        
        public static T[] Reverse<T>(T[] array)
        {
            T[] result = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
                result[i] = array[array.Length - i - 1];
            return result;
        }
        public static string Vowels(string input)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach(char c in input)
                if(vowels.Contains(c))
                    throw new FormatException();
            return "Not Found!";
        }
    }
}
