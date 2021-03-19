using System;

namespace DayTwoPractice
{
    class Program
    {
        public static void EnterAndSaveCredentials()
        {
            string name = "";
            string description ="";
            int type = 0;
            double distinguishedParameter = 0.0;
            EquipmentType equipmentType = EquipmentType.Default;

            Console.WriteLine("Enter name of equipment");
            name = Console.ReadLine();
            Console.WriteLine("Enter description of equipment");
            description = Console.ReadLine();
            Console.WriteLine("Enter Type of Equipment(1 For Mobile,2 For Immobile");
            type = Utility.ValidEntryInt();

            if(type == 1)
            {
                equipmentType = EquipmentType.Mobile;
                Console.WriteLine("Enter number of wheels.");
                distinguishedParameter = Utility.ValidEntryDouble();

            }
            else if (type==2)
            {
                equipmentType = EquipmentType.Immobile;
                Console.WriteLine("Enter weight.");
                distinguishedParameter = Utility.ValidEntryDouble();
            }
            else
            {
                Console.WriteLine("Enter valid format for equipment type");
            }
            Console.WriteLine(name + description + type + distinguishedParameter + equipmentType);

            //inventory.AddEquipment(name, description, equipmentType, distinguishedParameter);
        }
        /*
        static void Main(string[] args)
        {
            while (true)
            {
                bool flag = false;
                Console.WriteLine("Enter 1 to create an equipment. \nEnter 2 to move an equipment.");
                Console.WriteLine("Enter 3 to show details of equipment.");
                Console.WriteLine("Enter 4 to exit.");

                int input = 0;
                try{
                    input = Convert.ToInt32(Console.ReadLine()); 
                }
                catch(Exception e)
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
                    
                    case 4:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("Enter valid functionality number.");
                        break;

                }

                if(flag)
                    break;
            }
            
        }
        */
    
    
    }
}
