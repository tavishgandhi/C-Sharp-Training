using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Q1
{
    class Inventory
    {
        List<Equipment> MobileEquipments; // List of Mobile Equipments in Inventory
        List<Equipment> ImmobileEquipments; // // List of Immobile Equipments in Inventory

        public Inventory() // Constructor
        {
            //Console.WriteLine("Inside Inventory Constructor");

            MobileEquipments = new List<Equipment>();
            ImmobileEquipments = new List<Equipment>();
        }

        // To add the equipment in store
        public void AddEquipment(string name, string description, EquipmentType equipmentType, double distinguishedParam)
        {
            if (equipmentType == EquipmentType.Mobile) // For Mobile equipments
            {

                int wheels = Convert.ToInt32(distinguishedParam);
                Mobile equipment = new Mobile(name, description, equipmentType, wheels);
                MobileEquipments.Add(equipment);
            }
            else // For immobile equipments
            {
                double weight = distinguishedParam;
                Immobile equipment = new Immobile(name, description, equipmentType, weight);
                ImmobileEquipments.Add(equipment);
            }
        }

        // Moving an equipment by the given distance
        public void MoveBy(string name, EquipmentType equipmentType, double distance)
        {
            Equipment equipment = this.findEquipment(equipmentType, name);

            if (equipment is not null)
                equipment.MoveBy(distance);
            else
                Console.WriteLine("Equipment not found ");
        }

        // To Find an equipment
        public Equipment findEquipment(EquipmentType equipmentType, string name)
        {
            if (equipmentType == EquipmentType.Mobile) // For Mobile equipments
            {
                if (MobileEquipments.Count > 0)
                {
                    foreach (Equipment equipment in MobileEquipments)
                    {
                        string equipmentName = equipment.Name;
                        if (equipmentName.Equals(name)) // Searching on basis of name
                        {
                            return equipment;
                        }
                    }
                }
            }
            else // For Immobile equipments
            {
                if (ImmobileEquipments.Count > 0)
                {
                    foreach (Equipment equipment in ImmobileEquipments)
                    {
                        if (equipment.Name.Equals(name))
                        {
                            return equipment;
                        }
                    }
                }
            }
            return null;
        }
        
        // Listing all Mobile Equipments                  
        public void ListAllMobileEquipments() 
        {
            if (MobileEquipments.Count > 0) // If there are Mobile equipments in store
            {
                Console.WriteLine("\nDetails of All Mobile Equipments - ");
                foreach (var equipment in MobileEquipments)
                {
                    Console.WriteLine($"\nName of Equipment = {equipment.Name}." +
                        $"\nDescription = {equipment.Description}");

                }
            }
            else                            //If there are no Mobile equipments in store
            {
                Console.WriteLine("No Mobile equipment in store yet.");
            } 
        }

        // Listing all Immobile equipments                                    
        public void ListAllImmobileEquipments() 
        {
            if (ImmobileEquipments.Count > 0) //If there are Immobile equipments in store
            {
                Console.WriteLine("\nDetails of All Immobile Equipments - ");
                foreach (var equipment in ImmobileEquipments)
                {
                    Console.WriteLine($"\nName of Equipment = {equipment.Name}." +
                        $"\nDescription = {equipment.Description}");

                }
            }
            else //If there are no Immobile equipments in store
            {
                Console.WriteLine("No Immobile equipment in store yet.");
            }
            
        }

        // List of equipments not moved till now
        public void ListEquipmentsNotMoved()
        {

            var mobileEquipmentsNotMoved = from e in MobileEquipments
                                           where e.DisMovedTillDate == 0
                                           select e.Name;

            if (mobileEquipmentsNotMoved.Count() > 0)
            {
                foreach (var name in mobileEquipmentsNotMoved)
                {
                    Console.WriteLine("\nNames of equipment that have not been moved till now ");
                    Console.WriteLine($"Equipment =  {name}");
                }
            }
            else
            {
                Console.WriteLine("No such equipments");
            }

        }

        // Listing all equipments
        public void ListAllEquipments()
        {
            if(MobileEquipments.Count > 0 || ImmobileEquipments.Count > 0)
            {
                Console.WriteLine("\nDetails - ");
                foreach (var e in MobileEquipments)
                {
                    Console.WriteLine($"Name of Equipment = {e.Name}.\nDescription = {e.Description}");
                }
                foreach (var e in ImmobileEquipments)
                {
                    Console.WriteLine($"\nName of Equipment = {e.Name}.\nDescription = {e.Description}");
                }
            }
            else
            {
                Console.WriteLine("No elements in store yet.");
            }

        }

        // Printing details of an equipment
        public void PrintDetails(EquipmentType equipmentType, string name)
        {
            Equipment equipment = findEquipment(equipmentType, name);
            // Check if equipment exists
            if (equipment is not null)
            {
                Console.WriteLine($"\nName = {equipment.Name}");
                Console.WriteLine($"Description = {equipment.Description} ");
                Console.WriteLine($"Distance Moved Till Date = {equipment.DisMovedTillDate} ");
                Console.WriteLine($"Maintainance Cost = {equipment.MaintainanceCost}");
                Console.WriteLine($"Equipment Type = {equipment.equipmentType} ");

                if (equipment.equipmentType == EquipmentType.Immobile)
                {
                    Immobile immobileEquipment = (Immobile)equipment;
                    Console.WriteLine($"Weight = {immobileEquipment.Weight} ");
                }
                else
                {
                    Mobile mobileEquipment = (Mobile)equipment;
                    Console.WriteLine($"Wheels = {mobileEquipment.Wheels}");
                }
            }
            else
            {
                Console.WriteLine("The given equipment was not found.");
            }
        }

        // Deletion of equipments

        // Deleting all equipments
        internal void DeleteAllEquipmet()
        {
            Console.WriteLine("Deleting all equipments from store.");
            MobileEquipments.Clear();
            ImmobileEquipments.Clear();
        }

        // Deleting all mobile equipments
        internal void DeleteAllMobileEquipmet()
        {
            Console.WriteLine("Deleting all Mobile equipments from store.");
            MobileEquipments.Clear();
        }
        // Deleting all immobile equipments
        internal void DeleteAllImmobileEquipment()
        {
            Console.WriteLine("Deleting all Immobile equipments from store.");
            ImmobileEquipments.Clear();
        }

        // Deleting an equipment
        public void DeleteEquipment(string name, EquipmentType equipmentType)
        {
            if(equipmentType == EquipmentType.Mobile)
            {
                MobileEquipments.RemoveAll(e => e.Name == name);
            }
            else
            {
                ImmobileEquipments.RemoveAll(e => e.Name == name);
            }

            Console.WriteLine("\nElement Deleted");
        }

        
        

    }
}
