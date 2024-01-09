using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Enter Number Of Elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements in Assending order");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the element to be searched");
            int key = int.Parse(Console.ReadLine());
            BinarySearch binarySearch = new BinarySearch();

            Console.WriteLine(binarySearch.BinarySearchAlgo(arr, key));
            }
    }
}
