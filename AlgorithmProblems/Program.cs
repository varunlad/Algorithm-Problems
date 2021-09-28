using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //Adding Elements in a List
            list.Add(1);
            list.Add(5);
            list.Add(7);
            list.Add(3);
            list.Add(17);
            list.Add(10);
            list.Add(13);
            list.Add(9);
            Console.WriteLine("Unsorted List");
            list.ForEach(Console.WriteLine);//Displaying UnSorted List
            Sorting obj = new Sorting();
            obj.BubbleSort(list);
            Console.WriteLine("\nSorted List");
            list.ForEach(Console.WriteLine);//Displaying Sorted List
            Console.ReadLine();
          
        }
    }
}
