using System;
using System.Collections.Generic;

namespace Day2Q2
{
    public class DuckService
    {
        List<Duck> ducks = new List<Duck>();

        public List<Duck> findDuck(int numOfWings, DuckType duckType)
        {
            List<Duck> requiredDucks = new List<Duck>();
            if (ducks.Count > 0)
            {
                foreach(Duck duck in ducks)
                {
                    if(duck.numOfWings == numOfWings && duck.duckType == duckType)
                    {
                        requiredDucks.Add(duck);   
                    }
                }
            }
            else
            {
                Console.WriteLine("The List of ducks is empty");
            }
            return requiredDucks;
        }

        public void showDetails(int numOfWings, DuckType duckType)
        {
            List<Duck> requiredDucks = findDuck(numOfWings, duckType);
            if (requiredDucks.Count > 0)
            {
                foreach(Duck duck in requiredDucks)
                {
                    Console.WriteLine("/n");
                    duck.showDetails();
              
                }
            }
            else
            {
                Console.WriteLine("No such duck exists");
            }
        }

        public void CreateDuck(double weight, int numOfWings, DuckType duckType)
        {
            Duck duck;

            while (true)
            {
                if (duckType == DuckType.Rubber)
                {
                    duck = new Rubber(weight, numOfWings, duckType);
                    break;
                }
                else if (duckType == DuckType.Mallard)
                {
                    duck = new Mallard(weight, numOfWings, duckType);
                    break;
                }
                else if (duckType == DuckType.RedHead)
                {
                    duck = new RedHead(weight, numOfWings, duckType);
                    break;
                }
                else
                {
                    Console.WriteLine("No such Duck Type exists");
                }
            }
            ducks.Add(duck);
            Console.WriteLine("Duck added succesfully");
        }

        
    }
}