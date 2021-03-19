using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentsWeek1
{
    class DayOneQ3
    {
        static void Prime(string[] args)
        {
            int Left;
            int Right;
            while (true) // Loop until inputs are valid
            {
                Console.WriteLine("Enter 2 non equal numbers of range(2-1000)" +
                    "\nEnter First Number  - ");

                Left = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number - ");
                Right = Convert.ToInt32(Console.ReadLine());
                if (Left == Right)
                    Console.WriteLine("Kindly enter non-equal numbers.");
                else if (Left > Right)
                    Console.WriteLine("Kindly enter second number larger than first.");
                else if(Left < 2|| Right > 1000)
                    Console.WriteLine("Enter numbers in given range.");
                else
                {
                    break;
                }

            }

            List<Int32> primes = new List<int>();
            calculatePrimeinRange(Left, Right, primes); // Utility to fill list with prime of given range
            printList(primes);
        }

        static void printList(List<Int32> list)
        {
            foreach (int number in list) // Printing prime in list
            {
                Console.WriteLine(number);
            }
        }
        static void calculatePrimeinRange(int Left, int Right, List<Int32> list)
        {
            for (int start = Left; start < Right; start++)
            {
                bool flag = false;
                for (int temp = 2; temp <= start / 2; temp++)
                {

                    if (start % temp == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    list.Add(start);
            }
        }
    }
}
