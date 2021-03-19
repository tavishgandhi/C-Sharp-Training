using System;
namespace DayTwoPractice
{
    class MainFile
    {
        private static Inventory inventory = new Inventory();

        static void Main(String[] args)
        {
            while (true)                // Taking input until user exits
            {
                bool flag = false;
                Console.WriteLine("\nEnter 1 to create an equipment. \nEnter 2 to move an equipment.");
                Console.WriteLine("Enter 3 to show details of equipment.");
                Console.WriteLine("Enter 4 to exit.");

                int input = 0; 
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Kindly enter valid format");
                }

                switch (input)
                {
                    case 1:                // For creating a new equipment
                        EnterAndSaveCredentials();// Method to create and save new equipment
                        Console.WriteLine("Equipment Created and Added in Store");
                        break;
    
                    case 2:                // For moving an equipment
                        ToMoveEquipment(); // Method to move equipment by given distance
                        break;
    
                    case 3:                // To show given equipment details
                        PrintDetails();    // Printing Details of the given equipment
                        break;
    
                    case 4:                // Exiting
                        flag = true;
                        break;

                    default:               // If invalid number is added
                        Console.WriteLine("Enter valid functionality number.");
                        break;

                }

                if (flag)
                    break;
            }
        }
        // Method to enter and save equipment details
        private static void EnterAndSaveCredentials() 
        {
            // default properties
            string name = "";
            string description = "";
            int type = 0;
            double distinguishedParameter = 0.0;
            EquipmentType equipmentType = EquipmentType.Default;

            // Taking input
            Console.WriteLine("Enter name of equipment");
            name = Console.ReadLine();
            Console.WriteLine("Enter description of equipment");
            description = Console.ReadLine();
            Console.WriteLine("Enter Type of Equipment(1 For Mobile,2 For Immobile");
            type = Utility.ValidEntryInt();

            while (true)
            {
                if (type == 1) // If equipment  = Mobile
                {
                    equipmentType = EquipmentType.Mobile;
                    Console.WriteLine("Enter number of wheels.");
                    distinguishedParameter = Utility.ValidEntryDouble();
                    break;

                }
                else if (type == 2) // If equipment  = Immobile
                {
                    equipmentType = EquipmentType.Immobile;
                    Console.WriteLine("Enter weight.");
                    distinguishedParameter = Utility.ValidEntryDouble();
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid format for equipment type");
                }
            }

            inventory.AddEquipment(name, description, equipmentType, distinguishedParameter);
        }
        private static void ToMoveEquipment() // Method to move equipment
        {
            EquipmentType type;
            string name;
            double distance;

            Console.WriteLine("Enter Type of Equipment(1 For Mobile, 2 For Immobile)");
            type = Utility.ValidEquipmentType();

            Console.WriteLine("Enter Name of Equipment");
            name = Console.ReadLine();

            Console.WriteLine("Enter the distance to be moved");
            distance = Convert.ToDouble(Console.ReadLine());

            // Calling inventory to move a certain equipment by given distance
            inventory.MoveBy(name, type, distance);
        }

        // Printing Details of the given equipment
        private static void PrintDetails()
        {
            EquipmentType type;
            string name;

            Console.WriteLine("Enter Type of Equipment(1 For Mobile, 2 For Immobile)");
            type = Utility.ValidEquipmentType();

            Console.WriteLine("Enter Name of Equipment");
            name = Console.ReadLine();

            inventory.PrintDetails(type, name);
        }
    }
}