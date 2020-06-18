using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputedNumber=0;
            int counter = 0;
            Console.WriteLine("Enter a number and then press Enter");
            inputedNumber = Convert.ToInt64(Console.ReadLine());
            for (long divisorNumber = 2; divisorNumber <= inputedNumber; ++divisorNumber)
            {
                if (inputedNumber % divisorNumber == 0)
                {
                    counter++;
                    //Console.Write(divisorNumber + "\t");
                    while (inputedNumber % (divisorNumber * divisorNumber) == 0)
                    {
                        inputedNumber /= divisorNumber;
                        
                    }
                }
              
            }
            Console.Write(counter);
            Console.ReadLine();
        }
    }
}
