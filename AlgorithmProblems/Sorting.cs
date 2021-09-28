using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
   public class Sorting
    {
        public void BubbleSort(List<int> list)
        {
            int size = list.Capacity;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (list[j] > list[j + 1])//Checking for Values in a list Higher value Will move ahed in The List
                    {
                        int temp = list[j];//Taking Higher Value in temp variable
                        list[j] = list[j + 1];// cassigning next element in the list with current element
                        list[j + 1] = temp;//making next Element as Current Element
                    }
                }
            }
        }
    }
}
