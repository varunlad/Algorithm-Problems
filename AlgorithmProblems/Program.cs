using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Program
    {
        static int searching(int[] array, int first, int last, int value)
        {
            int middle = (first + last) / 2;//finding Middle
            if (array[middle] == value)
            {
                return middle;
            }
            if (first >= last)//checking if the array contain more than one element
            {
                return -1;
            }
            if (value < array[middle])
            {
                return searching(array, first, middle, value);
            }
            else
            {
                return searching(array, middle, last, value);
            }
        }



        // Driver method to test above
        public static void Main()
        {
            var numbers = new[] { 1,5,0,34,3,9,11,12,13,14,15,16,17,18,19,20,67,27,2,3,4,6,7,8,10 };
           // Array.Sort(numbers);
            Console.WriteLine("Think of a number");
            Console.WriteLine("Enter number you were thinking of ");
            int num = Convert.ToInt32(Console.ReadLine());//reading a number which you enter
            var index = searching(numbers,0,numbers.Length-1, num);
            Console.WriteLine("Number {0} is present at index:-",num);
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}

