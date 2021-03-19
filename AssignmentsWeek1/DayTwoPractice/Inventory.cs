using System;
using System.Collections.Generic;

namespace DayTwoPractice
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

            if(equipment is not null)
                equipment.MoveBy(distance);
            else
                Console.WriteLine("Equipment not found ");
        }

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
                if(ImmobileEquipments.Count > 0)
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
        
    }
}