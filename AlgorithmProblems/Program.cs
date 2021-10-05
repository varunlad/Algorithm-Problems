using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Program
    { 
        public static void Main()
        {
            var numbers = new[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };//Taking an array of 20 numbers
            bool num = true; ;
            Console.WriteLine("Think of a number between 1 and 20");     
            int first = 0;
            int last = numbers.Length ;
            int middle = (first + last) / 2;         
            int digit;
            while (num)//Loop will Continue till it becomes false
            {
                Console.WriteLine("Is your number :" + middle);
                Console.WriteLine("If not Click 1 if your number is less than : " + middle);
                Console.WriteLine("If not Click 2 if number is greater than  :" + middle);
                Console.WriteLine("Yes than Click 3 to exit");
                 digit = Convert.ToInt32(Console.ReadLine());
                switch (digit)
                {
                    case 1:
                        first = first;
                        last = middle - 1;  //Making last Element as last to the Middle Element                     
                        middle = (first + last) / 2;                     
                        break;
                    case 2:
                        first = middle + 1;//Making First element as next to the Middle Element
                        last = last;
                        middle = (first + last) / 2;                     
                        break;
                    case 3:
                        num = false;
                        break;
                }
            }
                
                

          

        }

    }
}

