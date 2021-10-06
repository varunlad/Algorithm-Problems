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
                //Receive Words from User  
                Console.Write("Enter first word:");
                string firstWord = Console.ReadLine();
                Console.Write("Enter second word:");
                string secondWord = Console.ReadLine();
               
                //step 1  
                char[] char1 = firstWord.ToLower().ToCharArray();
                char[] char2 = secondWord.ToLower().ToCharArray();

                //Step 2  
                Array.Sort(char1);
                Array.Sort(char2);

                //Step 3  
                string NewWord1 = new string(char1);
                string NewWord2 = new string(char2);

                //Step 4  
                //ToLower allows to compare the words in same case, in this case, lower case.  
                if (NewWord1 == NewWord2)
                {
                    Console.WriteLine("Yes! Words are Anagrams");
                }
                else
                {
                    Console.WriteLine("No! Words are not Anagrams");
                }
                Console.ReadLine();
            }
        }




    }

    


