using System;

namespace Day3Q1
{
    class MainFile
    {
        private static Inventory inventory = new Inventory();

        static void Main(String[] args)
        {
            while (true)                // Taking input until user exits
            {
                bool flag = false;
                Console.WriteLine("\nEnter 1 to create an equipment.");
                Console.WriteLine("Enter 2 to move an equipment.");
                Console.WriteLine("Enter 3 to show details of equipment.");
                Console.WriteLine("Enter 4 to delete an equipment.");
                Console.WriteLine("Enter 5 to list all equipments.");
                Console.WriteLine("Enter 6 to list all mobile equipments.");
                Console.WriteLine("Enter 7 to list all immobile equipments.");
                Console.WriteLine("Enter 8 to list all equipments that have not been moved yet.");
                Console.WriteLine("Enter 9 to delete all equipments in store.");
                Console.WriteLine("Enter 10 to delete all mobile equipments.");
                Console.WriteLine("Enter 11 to delete all immobile equipments.");
                Console.WriteLine("Enter 12 to exit.");

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

                    case 4:                // Delete an equipment
                        DeleteEquipment();
                        break;

                    case 5:
                        ListAllEquipments();
                        break;

                    case 6:
                        ListAllMobileEquipments();
                        break;

                    case 7:
                        ListAllImmobileEquipments();
                        break;

                    case 8:
                        ListEquipmentsNotMoved();
                        break;

                    case 9:
                        DeleteAllEquipments();
                        break;

                    case 10:
                        DeleteAllMobileEquipmet();
                        break;

                    case 11:
                        DeleteAllImmobileEquipment();
                        break;

                    case 12:                // Exiting
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

        private static void DeleteAllImmobileEquipment()
        {
            inventory.DeleteAllImmobileEquipment();
        }

        private static void DeleteAllMobileEquipmet()
        {
            inventory.DeleteAllMobileEquipmet();
        }

        private static void DeleteAllEquipments()
        {
            inventory.DeleteAllEquipmet();
        }

        private static void ListEquipmentsNotMoved()
        {
            inventory.ListEquipmentsNotMoved();
        }
        private static void ListAllImmobileEquipments()
        {
            inventory.ListAllImmobileEquipments();
        }
        private static void ListAllEquipments()
        {
            inventory.ListAllEquipments();
        }
        private static void ListAllMobileEquipments()
        {
            inventory.ListAllMobileEquipments();
        }

        private static void DeleteEquipment()
        {
            Console.WriteLine("Enter name of the equipment to be removed.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Type of Equipment to remove.(1 for Mobile, 2 for Immobile)");
            EquipmentType equipmentType = Utility.ValidEquipmentType();

            inventory.DeleteEquipment(name, equipmentType);// Calling inventory to remove a method
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
