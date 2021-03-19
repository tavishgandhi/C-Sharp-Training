using System;

namespace Day3Q1
{
    public class Utility
    {
        public static EquipmentType ValidEquipmentType()
        {
            EquipmentType type;
            while (true)
            {
                int input = ValidEntryInt();
                if (input == 1)
                {
                    type = EquipmentType.Mobile;
                    break;
                }
                else if (input == 2)
                {
                    type = EquipmentType.Immobile;
                    break;
                }
                else
                {
                    Console.WriteLine($"Enter valid number for Equipment " +
                        $"Type(1 For Mobile, 2 For Immobile");
                }
            }
            return type;
        }
        public static int ValidEntryInt()
        {
            int result;
            while (true)
            {
                try
                {
                    result = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter valid number");
                }
            }
            return result;
        }

        public static double ValidEntryDouble()
        {
            double result;
            while (true)
            {
                try
                {
                    result = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter valid number");
                }
            }
            return result;
        }
    }
}