using System;
using System.Collections.Generic;
using System.Linq;
namespace Day4A1Q1
{
    delegate bool MoreThan5(int num);
    

    public class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11
            };

            // 1.	Find odd - Lambda Expression – without curly brackets
            var FindOdd = list.Where(i => i % 2 != 0);
            Console.WriteLine("\nFind odd - Lambda Expression – without curly brackets");
            foreach(var num in FindOdd)
                Console.WriteLine(num);

            // 2.	Find Even - Lambda Expression – with curly brackets
            var FindEven = list.Where(x =>
            {
                if (x % 2 == 0)
                    return true;
                else
                    return false;

            });
            Console.WriteLine("\nFind Even - Lambda Expression – with curly brackets");
            foreach (var num in FindEven)
                Console.WriteLine(num);

            // 3.Find Prime – Anonymous Method
            var FindPrime = list.Where(
                delegate (int num )
                {
                    if (num == 1 || num == 0)
                        return false;

                    bool flag = false;
                    for (int i = 2; i <= num / 2; i++)
                    { 
                       if (num % i == 0)
                       {
                          flag = true;
                          break;
                       }
                    }
                    if (!flag) { return true; }
                    else { return false; }                       
                }
            );

            Console.WriteLine("\nFind Prime – Anonymous Method");
            foreach(var num in FindPrime)
                Console.WriteLine(num);

            //4.	Find Prime Another – Lambda Expression
            var FindPrimeAnother = list.Where(num =>
            {
                if (num == 1 || num == 0)
                    return false;

                bool flag = false;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag) { return true; }
                else { return false; }
            });

            Console.WriteLine("\nFind Prime Another – Lambda Expression");
            foreach (var num in FindPrimeAnother)   
                Console.WriteLine(num);
            
              
            //5 Find Elements Greater Than Five – Method Group Conversion Syntax
             static bool FindElementMoreThan5(int num)
             {
                return num > 5;
             }
             MoreThan5 moreThan5 = FindElementMoreThan5;
             var listMoreThan5 = list.Where(x => moreThan5(x));
             Console.WriteLine("\nFind Elements Greater Than Five–Method Group Conversion Syntax");
             foreach (int num in listMoreThan5)
             {
                Console.WriteLine(num);
             }

            //6.	Find Less than Five – Delegate Object in Where – // Method Group Conversion Syntax in Constructor of Object
            Question6Onwards question6Onwards = new Question6Onwards();
            question6Onwards.Question6(list);

            //7.	Find 3k – Delegate Object in Where – //Lambda Expression in Constructor of Object
            question6Onwards.Question7(list);

            //8.Find 3k + 1 - Delegate Object in Where –Anonymous Method in Constructor of Object
            question6Onwards.Question8(list);


            // 9.Find 3k + 2 - Delegate Object in Where –Lambda Expression Assignment
            Three_k2 three_K2 = (int num) =>
            {
                return (3 * num + 2);
            };
            Console.WriteLine("3k + 2 – Lambda Expression Assignment");
            foreach (var num in list)
              Console.WriteLine(three_K2(num));
            

            //10.	Find anything - Delegate Object in Where – Anonymous Method Assignment Find Anything  = Multiple of 3
            Multiple3 multiple3 = delegate (int num)
            {
               return (num % 3 == 0);

            };
            var listMultiple3 = list.Where(x => multiple3(x));
            Console.WriteLine("Multiple of 3 – Anonymous Method Assignment");
            foreach (var num in listMultiple3)
               Console.WriteLine(num);

            
            //11.Find anything - Delegate Object in Where – Method Group Conversion Assignment
            bool MultipleOf4(int num)
            {
               return num % 4 == 0;
            }
              Multiple4 multiple4 = MultipleOf4;

            var listMultiple4 = list.Where(x => multiple4(x));
            Console.WriteLine("Multiple of 4 – Method Group Conversion Assignment");
            foreach (var num in listMultiple4)
               Console.WriteLine(num);

        }
    }
}
