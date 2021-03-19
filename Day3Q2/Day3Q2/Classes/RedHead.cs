using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3Q2.Enum;

namespace Day3Q2.Classes
{
    public class RedHead : Duck
    {
        public RedHead(double weight, int numOfWings, DuckType duckType) :
            base(weight, numOfWings, duckType)
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
