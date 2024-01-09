using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchingAlgo
{
    internal class BinarySearch
    {
        //public BinarySearch()
        //{
        //    Console.WriteLine("Enter Number Of Elements");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter {n} elements in Assending order");
        //    int[] arr = new int[n];
        //    foreach (int i in arr)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }

        //    Console.WriteLine("Enter the element to be searched");
        //    int key = int.Parse(Console.ReadLine());

        //    Console.WriteLine(BinarySearchAlgo(arr, key));
        //}
        public int BinarySearchAlgo(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int midNum = arr[mid];

                if(key == midNum)
                {
                    return mid;
                }
                if(key > midNum)
                {
                    low = mid + 1;
                }else
                {   
                    high = mid - 1;
                }
            }return -1;
        }
    }
}
