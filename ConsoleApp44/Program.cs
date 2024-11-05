using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Progrm
    {
        static void Main(string[] args)
        {
            string[] strings = { "painkiller", "wonder", "city", "marooned", "liar", "zebra" };

            SortByLength(strings);

            Console.WriteLine("Sorted strings: ");
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }

        static void SortByLength(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[i].Length > arr[j + 1].Length)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[i + 1] = temp;
                    }
                }
            }
        }
    }
}
