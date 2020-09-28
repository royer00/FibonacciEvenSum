using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

        static void Main(string[] args)
        {
            //counter
            int total = 0;
            int secondNum = 0;
            int thirdNum = 0;
            int startingNum = 1;
            while (startingNum < 4000000)
            {
                //Backwards assignment to get fibonacci
                thirdNum = secondNum;
                secondNum = startingNum;
                startingNum = secondNum + thirdNum;
                //checking for even terms
                if (startingNum % 2 == 0)
                {
                    //adding to counter
                    total += startingNum;
                }
            }

            Console.WriteLine(total);


        }
    }
}
