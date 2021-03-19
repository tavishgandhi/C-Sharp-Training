using System;


namespace Day2Q2
{
    public class Rubber : Duck
    {
        public QuackType quackType { get; set; }
        public FlyType flyType { get; set; }

        public Rubber(double weight, int numOfWings, DuckType duckType) : base(weight, numOfWings, duckType)
        {
            this.quackType = QuackType.Squeak;
            this.flyType = FlyType.DoNot;
        }

        public override void showDetails()
        {
            Console.WriteLine("Weight = " + this.weight);
            Console.WriteLine("Number of Wings = " + this.numOfWings);
            Console.WriteLine("Duck Type = " + this.duckType);
            Console.WriteLine("Fly Type = " + this.flyType);
            Console.WriteLine("Quack Type = " + this.quackType);
        }
    }
}