using System;

namespace Day2Q2
{
    class MainFile
    {
        // Making 
        public static DuckService service = new DuckService(); 
            
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Duck simulation!");
                Console.WriteLine("Enter 1 to create a duck");
                Console.WriteLine("Enter 2 to print details of a duck");
                Console.WriteLine("Enter 3 to exit the program");

                bool flag = false;
                int input = Utility.ValidEntryInt();
                switch (input)
                {
                    case 1:
                        CreateDuck();
                        break;
                    case 2:
                        PrintDetails();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Enter a correct range number.");
                        break;
                }
                if(flag)
                    break;
            }
        }
        private static void PrintDetails()
        {
            int numOfWings;
            DuckType duckType;

            Console.WriteLine("Enter the Type of the required Duck");
            duckType = Utility.ValidEntryDuckType();

            Console.WriteLine("Enter number of wings of the Duck");
            numOfWings = Utility.ValidEntryInt();

            service.showDetails(numOfWings, duckType);
        }

        private static void CreateDuck()
        {
            double weight = 0.0;
            int numOfWings = 0;
            DuckType duckType = DuckType.None;

            Console.WriteLine("Enter weight of the duck");
            weight = Utility.ValidEntryDouble();

            Console.WriteLine("Enter number of wings of the duck");
            numOfWings = Utility.ValidEntryInt();

            Console.WriteLine("Enter Type of the duck.");
            duckType = Utility.ValidEntryDuckType();

            service.CreateDuck(weight,numOfWings,duckType);
        }
    }
}
