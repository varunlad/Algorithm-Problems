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
            string[] words = { "tiger","lion","rat","elephant","monkey"};
            Console.WriteLine("Unsorted List :");
            Display(words);
            Sort(words);
        }
        public void Sort(string[] words)
        {
            for (int i = 1; i < words.Count(); i++)//Starting loop from i=1 postion
            {
                string temp = words[i];
                int j = i - 1;
                while (j >= 0 && words[j].CompareTo(temp) > 0)//Loop till privious element is greater than current element
                {
                    words[j + 1] = words[j];//Swap Right greater Element
                    j=j-1;
                }
                words[j + 1] = temp;
            }
            Console.WriteLine("The sorted List of Words is :-");
            Display(words);
        }
        public void Display(string[] words)//Displaying sorted array
        {
            foreach(var elements in words)
            {
                Console.WriteLine(elements+"\t");
            }
        }
    }
}

