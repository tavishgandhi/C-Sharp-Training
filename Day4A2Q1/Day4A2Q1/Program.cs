using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day4A2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11
            };
            Console.WriteLine("Extension methods. \n ");

            foreach (int i in list)
            {
                Console.Write($"For the number =  {i.ToString()} \n");
                    
                if (i.IsEven()) 
                    Console.Write("\nThe number is Even.");

                if (i.IsOdd()) 
                    Console.WriteLine("\nThe number is Odd.");
                
                if (i.IsPrime()) 
                    Console.WriteLine("\nThe number is Prime Number.");
                
                if (i.IsDivisibleBy(5)) 
                    Console.WriteLine("\nThe number is Divisible by 5.");

                Console.WriteLine();
            }
        }
    }

    static class ExtensionMethod
    {
        public static bool IsDivisibleBy(this int i, int j)
        {
            return (i % j) == 0;
        }
        public static bool IsEven(this int i)
        {
            return (i % 2 == 0);
        }
        
        public static bool IsPrime(this int i)
        {
            if (i <= 1) return false;
            for (int j = 2; j <= i/2; ++j)
            {
                if ((i % j) == 0) return false;
            }
            return true;
        }

        
        public static bool IsOdd(this int i)
        {
            return (i % 2 != 0);
        }
    }
}
