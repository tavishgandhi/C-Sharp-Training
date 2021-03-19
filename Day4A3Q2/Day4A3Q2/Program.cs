using System;

namespace Day4A3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidInputs valid = new ValidInputs();

            int AttemptsCount = 0;
        Step1:
            AttemptsCount++;
            try
            {
                bool flag = valid.validAttempts(AttemptsCount);
                if (flag)
                {
                    Console.WriteLine("Enter number 1-5");
                    ValidInput input = valid.ValidInput();
                    if (!input.flag) goto Step1;
                    switch (input.value)
                    {
                        case 1:
                            Console.WriteLine("Enter an even number.");
                            ValidInput number = valid.ValidInput();
                            if (!number.flag) goto Step1;
                            try
                            {
                                if (valid.ValidEven(number.value))
                                {
                                    Console.WriteLine("Success");
                                }
                            }
                            catch(EvenException e)
                            {
                                Console.WriteLine(e.Message);
                                goto Step1;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter an odd number");
                            number = valid.ValidInput();
                            if (!number.flag) goto Step1;
                            try
                            {
                                if (valid.ValidOdd(number.value))
                                {
                                    Console.WriteLine("Success");
                                }
                            }
                            catch (OddException e)
                            {
                                Console.WriteLine(e.Message);
                                goto Step1;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter a prime number");
                            number = valid.ValidInput();
                            if (!number.flag) goto Step1;
                            try
                            {
                                if (valid.ValidPrime(number.value))
                                {
                                    Console.WriteLine("Success");
                                }
                            }
                            catch (PrimeException e)
                            {
                                Console.WriteLine(e.Message);
                                goto Step1;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter a negative number.");
                            number = valid.ValidInput();
                            if (!number.flag) goto Step1;
                            try
                            {
                                if (valid.ValidNegative(number.value))
                                {
                                    Console.WriteLine("Success");
                                }
                            }
                            catch (NegativeException e)
                            {
                                Console.WriteLine(e.Message);
                                goto Step1;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter zero number.");
                            number = valid.ValidInput();
                            if (!number.flag) goto Step1;
                            try
                            {
                                if (valid.ValidZero(number.value))
                                {
                                    Console.WriteLine("Success");
                                }
                            }
                            catch (ZeroException e)
                            {
                                Console.WriteLine(e.Message);
                                goto Step1;
                            }
                            break;
                        default:
                            Console.WriteLine("Enter input in valid range of 1-5");
                            goto Step1;
                            break;
                    }
                } 
            }
            catch (AttemptsException e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }
}
