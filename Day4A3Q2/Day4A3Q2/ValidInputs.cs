using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A3Q2
{
    class ValidInputs
    {
        public bool validAttempts(int count)
        {
            if (count > 5)
            {
                throw new AttemptsException("Number Count " + count);
            }
            return true;
        }

        public bool ValidEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else throw new EvenException("Number " + num);
        }
        public bool ValidOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else throw new OddException("Number " + num);
        }

        public ValidInput ValidInput()
        {
            int result = -1;
            bool flag = false;
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
                flag = true;
            }
            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);
            }
            ValidInput validInput = new ValidInput(flag, result);
            return validInput;
        }

        public bool ValidPrime(int number)
        {
            bool flag = false;
            for(int i = 2; i <= number/2; i++)
            {
                if(number%i ==0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                throw new PrimeException("Number + " + number);
            }
            return true;
        }

        public bool ValidNegative(int num)
        {
            if (num > 0)
                throw new NegativeException("Number  = " + num);
            return true;

        }
        public bool ValidZero(int num)
        {
            if (num != 0)
                throw new ZeroException("Number  = " + num);
            return true;
        }
    }
    class ValidInput
    {
        public bool flag {get; set;}
        public int value { get; set; }
        public ValidInput(bool flag , int value)
        {
            this.value = value;
            this.flag = flag;
        }
    }
}
