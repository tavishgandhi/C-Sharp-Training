using System;

namespace Day2Q2
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