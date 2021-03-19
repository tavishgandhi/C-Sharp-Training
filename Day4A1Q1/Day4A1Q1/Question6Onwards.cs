using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q1
{
    // Delegate for less than 5
    delegate bool LessThan5(int num);
    delegate int Three_k(int num);
    delegate int Three_k1(int num);
    delegate int Three_k2(int num);
    delegate bool Multiple3(int num);
    delegate bool Multiple4(int num);

    class Question6Onwards
    {
        LessThan5 ListLessThan5;
        Three_k three_K;
        Three_k1 three_K1;

        // Constructor
        public Question6Onwards()
        {
            // method group conversion in constructor of object
            this.ListLessThan5 = FindElementLessThan5;

            // Lambda in constructor of object
            three_K = x => { return 3 * x; };

            // Anonymous Method
            three_K1 = delegate (int num)
            {
                return (3 * num) + 1;
            };
        }

        //6.	Find Less than Five – Delegate Object in Where – // Method Group Conversion Syntax in Constructor of Object
        static bool FindElementLessThan5(int num)
        {
            return num < 5;
        }

        public void Question6(List<int> list)
        {
            var ListLessThan5 = list.Where(x => this.ListLessThan5(x));

            Console.WriteLine("Find Less than Five – Delegate Object in Where");
            foreach (var num in ListLessThan5)
                Console.WriteLine(num);
        }
        

        //7. Find 3k – Delegate Object in Where – Lambda Expression in Constructor of Object

        public void Question7(List<int> list)
        {

            Console.WriteLine("Find 3k Lambda Expression in Constructor of Object");
            foreach (var num in list)
                Console.WriteLine(three_K(num));
        }


        //8.Find 3k + 1 - Delegate Object in Where – //Anonymous Method in Constructor of Object
        public void Question8(List<int> list)
        {
            Console.WriteLine("Find 3k + 1 Anonymous Method in Constructor of Object");
            foreach (var num in list)
                Console.WriteLine(three_K1(num));
        }
    }
}
