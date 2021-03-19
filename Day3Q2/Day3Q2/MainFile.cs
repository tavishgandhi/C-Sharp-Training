using System;
using Day3Q2.Enum;
using Day3Q2.Service;
using Day3Q2.Utility;

namespace Day3Q2
{
    public class MainFile
    {
        // Making 
        public static DuckService duckservice = new DuckService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Duck simulation!");
                Console.WriteLine("Enter 1 to create and add a duck");
                Console.WriteLine("Enter 2 to print details of a duck");
                Console.WriteLine("Enter 3 to remove a duck.");
                Console.WriteLine("Enter 4 to remove all ducks");
                Console.WriteLine("Enter 5 to print all ducks in increasing order of their wings");
                Console.WriteLine("Enter 6 to print all ducks.");
                Console.WriteLine("Enter 7 to exit");

                bool flag = false;
                int input = UtilityHelper.ValidEntryInt();
                switch (input)
                {
                    case 1:
                        CreateDuck();
                        break;

                    case 2:
                        PrintDetails();
                        break;

                    case 3:
                        RemoveADuck();
                        break;

                    case 4:
                        RemoveAllDucks();
                        break;
                    
                    case 5:
                        PrintDetailsofAllDucks();
                        break;

                    case 6:
                        PrintDetailsofAllDucksOrderByWings();
                        break;

                    case 7:
                        Console.WriteLine("Exiting the program");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Enter a correct range number.");
                        break;
                }
                if (flag)
                    break;
            }
        }

        private static void RemoveADuck()
        {
            int numOfWings;
            DuckType duckType;

            Console.WriteLine("Enter the Type of the required Duck to be removed");
            duckType = UtilityHelper.ValidEntryDuckType();

            Console.WriteLine("Enter number of wings of the Duck to be removed");
            numOfWings = UtilityHelper.ValidEntryInt();

            duckservice.removeADuck(numOfWings, duckType);
        }

        private static void RemoveAllDucks()
        {
            duckservice.removeAllDucks();
        }

        private static void PrintDetails()
        {
            int numOfWings;
            DuckType duckType;

            Console.WriteLine("Enter the Type of the required Duck");
            duckType = UtilityHelper.ValidEntryDuckType();

            Console.WriteLine("Enter number of wings of the Duck");
            numOfWings = UtilityHelper.ValidEntryInt();

            duckservice.showDetails(numOfWings, duckType);
        }
        private static void PrintDetailsofAllDucks()
        {
            duckservice.PrintOrderByWeight();
        }

        private static void PrintDetailsofAllDucksOrderByWings()
        {
            duckservice.PrintOrderByWings();
        }

        private static void CreateDuck()
        {
            double weight = 0.0;
            int numOfWings = 0;
            DuckType duckType = DuckType.None;

            Console.WriteLine("Enter weight of the duck");
            weight = UtilityHelper.ValidEntryDouble();

            Console.WriteLine("Enter number of wings of the duck");
            numOfWings = UtilityHelper.ValidEntryInt();

            Console.WriteLine("Enter Type of the duck.");
            duckType = UtilityHelper.ValidEntryDuckType();

            duckservice.CreateDuck(weight, numOfWings, duckType);
        }
    }
}
