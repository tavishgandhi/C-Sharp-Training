using System;

namespace AssignmentsWeek1
{
    class DayOneQOne
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                // declaring variables
                float infloat = 0;
                int inint = 0;
                bool inbool;

                Console.WriteLine($"Enter Number");
                string input = Console.ReadLine();

                // Using "Convert.To" Method
                Console.WriteLine("\nUsing 'Convert.To' Method");

                try // For Float
                {
                    infloat = Convert.ToSingle(input);
                    Console.WriteLine($"Float = {infloat}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format for float {input}");
                }
                try // For Integer
                {
                    inint = Convert.ToInt32(infloat);
                    Console.WriteLine($"Integer = {inint}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format for Integer {input}");
                }
                try // For Boolean
                {
                    inbool = Convert.ToBoolean(input);
                    Console.WriteLine($"Bool = {inbool}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format for bool {input}");
                }
            
            //------------------------------------------------------------------------------------------

            // Using ".Parse" Method
                Console.WriteLine("\nUsing '.Parse' Method");

                try // For Float
                {
                    infloat = float.Parse(input);
                    Console.WriteLine($"Float = {infloat}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format for float {input}");
                }
                try // For int
                {
                    inint = int.Parse(input);
                    Console.WriteLine($"Integer = {inint}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format for Integer {input}");
                }
                try // For Bool
                {
                    inbool = bool.Parse(input);
                    Console.WriteLine($"Bool = {inbool}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format for Bool {input}");
                }

//------------------------------------------------------------------------------------------

                // Using ".TryParse" Method
                           
                Console.WriteLine("\nUsing 'TryParse' Method \n");

                if(float.TryParse(input, out infloat))
                    Console.WriteLine($"Float = {infloat}");
                else
                    Console.WriteLine("Invalid format, kindly input the correct number");

                if(int.TryParse(input, out inint))
                    Console.WriteLine($"Integer = {inint}");
                else
                    Console.WriteLine("Invalid format, kindly input the correct number");
                
                if(bool.TryParse(input,out inbool))
                    Console.WriteLine($"Boolean = {inbool}");
                else
                    Console.WriteLine("Invalid format, kindly input the true or false");

                Console.WriteLine("Do you want to continue (y/n)");
                if (Console.ReadLine().Equals("n"))
                {
                    break;
                }
            }

        }
         
    }
}
