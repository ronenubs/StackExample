using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<Int32> numbers = new ArrayStack<Int32>(5);

            try
            {
                numbers.Push(1); // 1
                numbers.Push(3); // 1 3
                numbers.Push(13); // 1 3 13
                numbers.Push(145); // 1 3 13 145
                numbers.Push(75); // 1 3 13 145 75
                numbers.Push(232);
            }
            catch(StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
