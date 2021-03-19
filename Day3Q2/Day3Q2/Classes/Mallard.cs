﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3Q2.Enum;

namespace Day3Q2.Classes
{
    public class Mallard : Duck
    {
        public QuackType quackType { get; set; }
        public FlyType flyType { get; set; }

        public Mallard(double weight, int numOfWings, DuckType duckType) :
            base(weight, numOfWings, duckType)
        {
            this.quackType = QuackType.Loud;
            this.flyType = FlyType.Fast;
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
