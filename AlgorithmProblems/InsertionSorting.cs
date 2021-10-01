using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class InsertionSorting
    {
        public void Inputs()
        {
            int[] numbers = { 5, 31, 4, 56, 7, 89, 3 };

            for (int i = 1; i < numbers.Length; i++)
            {
                int temp = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > temp)//Loop till privious element is greater than current element
                {
                    numbers[j + 1] = numbers[j];//Swap Right greater Element
                    j--;
                }
                numbers[j + 1] = temp;
            }
            Console.WriteLine("Sorted List of Numbers :-");
            foreach(int elements in numbers)
            {
                Console.Write(elements+"\t" );
            }
        }
        
        
    }
}

