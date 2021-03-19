using System;

namespace Day2Q2
{
    public class Utility
    {
        public static int ValidEntryInt()
        {
            int ans = 0;
            while (true)
            {
                try
                {
                    ans = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter a valid number.");
                }
            }
            return ans;
        }

        public static double ValidEntryDouble()
        {
            double ans;
            while (true)
            {
                try
                {
                    ans = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter a valid number.");
                }
            }
            return ans;
        }

        public static DuckType ValidEntryDuckType()
        {
            DuckType duckType = DuckType.None;

            bool flag = true;
            while (true)
            {
                Console.WriteLine("1 for Rubber, 2 for Mallard, 3 for RedHead");
                int type = Utility.ValidEntryInt();
                switch (type)
                {
                    case 1:
                        duckType = DuckType.Rubber;
                        break;
                    case 2:
                        duckType = DuckType.Mallard;
                        break;
                    case 3:
                        duckType = DuckType.RedHead;
                        break;
                    default:
                        Console.WriteLine("Enter a valid number in range");
                        flag = false;
                        break;
                }
                if (flag)
                    break;
            }
            return duckType;
        }
    }
}