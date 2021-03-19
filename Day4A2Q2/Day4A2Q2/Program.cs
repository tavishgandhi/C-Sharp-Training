using System;
using System.Linq;
using System.Collections.Generic;
namespace Day4A2Q2
{
    delegate bool Logic(int num);

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                6,7,8,9,10,11
            };
            
            //1.CustomAll - Should work as All operation of Linq, with custom logic passed as delegate
            bool res = list.CustomAll((x) => x > 5);
            Console.WriteLine(res);

            //2. CustomAny - Should work as Any operation of Linq, with custom logic passed as delegate
            res = list.CustomAny();
            Console.WriteLine(res);

            // 3.CustomMax - Should work as Max operation of Linq, with custom logic passed as delegate
            int result = list.CustomMax();
            Console.WriteLine("Custom Max same as Linq Max" + result);
            result = list.CustomMax();
            Console.WriteLine(list.CustomMax());
            Console.WriteLine("Custom Max with custom logic = " + res);

            //4.CustomMin - Should work as Min operation of Linq, with custom logic passed as delegate
            result = list.CustomMin();
            Console.WriteLine(
                );

        }
    }
}
