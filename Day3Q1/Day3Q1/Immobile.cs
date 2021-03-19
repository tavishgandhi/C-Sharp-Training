namespace Day3Q1
{
    public class Immobile : Equipment
    {
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Immobile(string name, string description, EquipmentType equipmentType, double weight) :
            base(name, description, equipmentType)
        {
            this.Weight = weight;
        }
        public override void MoveBy(double distance)
        {
            this.DisMovedTillDate += distance;
            this.MaintainanceCost += (distance * this.Weight);
        }
    }
}