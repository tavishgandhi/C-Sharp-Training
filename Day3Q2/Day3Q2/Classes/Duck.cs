using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3Q2.Enum;
using Day3Q2.Interface;

namespace Day3Q2.Classes
{
    public abstract class Duck : IDuck
    {
        public double weight { get; set; }
        public int numOfWings { get; set; }
        public DuckType duckType { get; set; }
        public QuackType quackType { get; set; }
        public FlyType flyType { get; set; }

        public Duck(double weight, int numOfWings, DuckType duckType)
        {
            this.weight = weight;
            this.numOfWings = numOfWings;
            this.duckType = duckType;
        } 

        public abstract void showDetails();
    }
}
