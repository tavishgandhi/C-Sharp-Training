namespace Day3Q1
{
    public class Mobile : Equipment
    {
        private int wheels;
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }

        public Mobile(string name, string description, EquipmentType equipmentType_, int wheels)
            : base(name, description, equipmentType_)
        {
            this.Wheels = wheels;
        }
        public override void MoveBy(double distance)
        {
            DisMovedTillDate += distance;
            MaintainanceCost += (distance * this.Wheels);
        }
    }
}