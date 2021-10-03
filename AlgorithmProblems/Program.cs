using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Program
    {

        static int BinarySearch(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == item)
                    return middle;

                if (item < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }


        // Driver method to test above
        public static void Main()
        {
            var numbers = new[] { 1, 5, 0, 34, 3, 9 ,67,27};
            
            Console.WriteLine("Enter number to be search");
            int num = Convert.ToInt32(Console.ReadLine());
            var index = BinarySearch(numbers, num);
            Console.WriteLine("It is present at index:-");
            Console.WriteLine(index);            
            Console.ReadLine();
        }
    }
}
