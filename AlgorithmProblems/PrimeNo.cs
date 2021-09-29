using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class PrimeNumber
    {
        public void Prime()
        {
            for (int i = 3; i <= 100; i++)//Outer For Loop to increment numbers from 2 till 1000
            {
                bool isPrime = true;
                for (int j = 2; j <=i/2; j++)//We check number till half of the number
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime number-->  "+i);//Printing Prime Number
                }
            }
        }
    }
}

