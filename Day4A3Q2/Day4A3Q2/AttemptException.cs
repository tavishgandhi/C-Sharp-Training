using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A3Q2
{
    public class AttemptException : Exception 
    {
        public AttemptException(string exception) : base(exception)
        {
            Console.WriteLine("Attempts exceeded then 5");
        }
    }
    public class AttemptsException : Exception
    {
        public AttemptsException(string exception) : base(exception)
        {
            Console.WriteLine("Attempts exceeded then 5");
        }
    }

    public class EvenException : Exception
    {
        public EvenException(string e) : base(e)
        {
            Console.WriteLine("Number is not even");
        }
    }
    public class OddException : Exception
    {
        public OddException(string e) : base(e)
        {
            Console.WriteLine("Number is not odd");
        }
    }
    public class  PrimeException : Exception
    {
        public PrimeException(string e) : base(e)
        {
            Console.WriteLine("Number is not prime.");
        }
    }
    public class NegativeException : Exception
    {
        public NegativeException(string e) : base(e)
        {
            Console.WriteLine("Number is not negative.");
        }
    }
    public class ZeroException : Exception
    {
        public ZeroException(string e) : base(e)
        {
            Console.WriteLine("Number is not zero");
        }
    }
    public class ValidationException : Exception
    {
        public ValidationException(string e) : base(e)
        {
            Console.WriteLine("Enter a valid number.");
        }
    }
}
