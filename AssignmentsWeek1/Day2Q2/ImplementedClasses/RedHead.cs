using System;


namespace Day2Q2
{
    public class RedHead : Duck
    {
        public RedHead(double weight, int numOfWings, DuckType duckType) :
            base(weight,numOfWings, duckType )
        {
            this.quackType = QuackType.Mild;
            this.flyType = FlyType.Slow;
        }

        public override void showDetails()
        {
            //base.showDetails();
            Console.WriteLine("Fly Type = " + this.flyType);
            Console.WriteLine("Quack Type = " + this.quackType);
        }
    }
}
