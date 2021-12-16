using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Calc
    {
        public void cal()
        {
            int x, y;
            int res = 0;
            Console.WriteLine("****Calculator****");
            Console.WriteLine("Choose your option");
            Console.WriteLine("\ta.Add");
            Console.WriteLine("\tb.Subtract");
            Console.WriteLine("\tc.Multiply");
            Console.WriteLine("\td.Divide");
            Console.WriteLine("\te.Exit");
            try
            {
                switch (Console.ReadLine())
                {

                    case "a":
                        Console.WriteLine("Enter the first number");
                        
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        y = Convert.ToInt32(Console.ReadLine());
                        res = x + y;
                        Console.WriteLine("Result:" + res);
                        break;
                    case "b":
                        Console.WriteLine("Enter the first number");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        y = Convert.ToInt32(Console.ReadLine());
                        res = x - y;
                        Console.WriteLine("Result:" + res);
                        break;
                    case "c":
                        Console.WriteLine("Enter the first number");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        y = Convert.ToInt32(Console.ReadLine());
                        res = x * y;
                        Console.WriteLine("Result:" + res);
                        break;
                    case "d":
                        Console.WriteLine("Enter the first number");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        y = Convert.ToInt32(Console.ReadLine());
                        res = x / y;
                        Console.WriteLine("Result:" + res);
                        break;
                    default:
                        res = 0;
                        break;


                }
                
            }
            catch(Exception ex)
            {

            }


        }
    }
}
