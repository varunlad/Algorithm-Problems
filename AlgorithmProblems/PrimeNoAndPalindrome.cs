using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class PrimeNumberandPalindrome
    {
        public void PrimeandPalindrome()
        {

            
            for (int i = 3; i <= 1000; i++)//Outer For Loop to increment numbers from 2 till 1000
            {
                int rev_no = 0;
                int n = i;
                while (n != 0)
                {
                    int r = n % 10;
                    rev_no = rev_no * 10 + r;
                    n = n / 10;
                }
              
                bool isPrime = true;
                for (int j = 2; j <=i/2; j++)//We check number till half of the number
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && rev_no == i)//checking for Prime as well as Palindrome Number
                {
                    Console.WriteLine("Prime number and Palindrome-->"+i);
                }
            }
        }
    }
}

