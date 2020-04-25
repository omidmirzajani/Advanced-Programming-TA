using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public static void Let(out int a, ref int b)
        {
            a = b;
        }
        public static void Square(ref int a)
        {
            a = a * a;
        }
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void SwapArray(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
                Swap(ref a[i], ref b[i]);
        }
        public static int MaximomValue(params int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > result)
                    result = nums[i];
            }
            return result;
        }
        public static int[] CommonIntegerElements(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            foreach (int num in nums1)
            {
                if (nums2.Contains(num))
                    result.Add(num);
            }
            int[] actual = result.OrderBy(d => d).ToArray();
            return actual;
        }


        public static string[] CommonStringElements(string[] str1, string[] str2)
        {
            List<string> result = new List<string>();
            foreach (string num in str1)
            {
                if (str2.Contains(num))
                    result.Add(num);
            }
            string[] actual = result.OrderBy(d => d).ToArray();
            return actual;
        }
        public static T[] CommonElements<T>(T[] set1, T[] set2)
        {
            List<T> result = new List<T>();
            foreach (T element in set1)
            {
                if (set2.Contains(element))
                    result.Add(element);
            }
            return result.ToArray();
        }
    }
}
