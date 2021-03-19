using System;

namespace DayTwoPractice
{
    public abstract class Equipment
    {
        public Equipment(string name, string description, EquipmentType equipmentType_)
        {
            this.Name = name;
            this.Description = description;
            this.equipmentType = equipmentType_;
            this.MaintainanceCost = 0;
            this.DisMovedTillDate = 0;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double disMovedTillDate;
        public double DisMovedTillDate
        {
            get { return disMovedTillDate; }
            set { disMovedTillDate = value; }
        }

        private double maintainanceCost;
        public double MaintainanceCost
        {
            get { return maintainanceCost; }
            set { maintainanceCost = value; }
        }

        private EquipmentType equipmentType_;
        public EquipmentType equipmentType
        {
            get { return equipmentType_; }
            set { equipmentType_ = value; }
        }

        public abstract void MoveBy(double distance);
    }
}