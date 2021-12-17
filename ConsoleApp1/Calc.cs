using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //*****************************Single responsibility**************************************//
    internal class Calc
    {
        private int a, b,c;

        #region
        
        //Ask the user how many parameters they want to enter
        public void getCount()
        {
            int ch;
            Console.WriteLine("How many parameters do you want to enter(2/3)?");
            ch=Int32.Parse(Console.ReadLine());
            switch (ch)
            {
                case 2:getInput(); break;
                    case 3:getInput1(); break;
                default:
                    Console.WriteLine("Invalid parameter entered");
                    break;
            }
        }
        #endregion

        #region
        //Get the inputs from user for 2 inputs
        public void getInput()
        {
            
            try
            {            
                Console.WriteLine("\nEnter first number");
                a=Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter second number");
                b=Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion

        #region
        //Get the inputs from user for 3 inputs
        public void getInput1()
        {
            try
            {
                Console.WriteLine("\nEnter first number");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter second number");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter third number");
                c = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region
        //To display the choice of user
        public static int display()
        {           
            try
            {
                    Console.WriteLine("\n*****************************Single responsibility**************************************");
                    Console.WriteLine("\n*********************************Calculator*********************************************");
                    Console.WriteLine("\t1.Add");
                    Console.WriteLine("\t2.Subtract");
                    Console.WriteLine("\t3.Multiply");
                    Console.WriteLine("\t4.Divide");
                    Console.WriteLine("\t5.Exit");
                    Console.WriteLine("\n****************************************************************************************");
                    Console.WriteLine("\nEnter your option");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
            
        }
        #endregion

        #region
        //Method to perform opertaions as per user's choice selection
        public void operation()
        {
            
            Services.ServicesCal obj = new Services.ServicesCal();
            try
            {

                int res = 0, ch = 0;
                string again;
                do
                {
                     display();
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        
                        case 1:
                            getCount();
                            var abc = obj.Add(a, b);
                            res = abc.Item3;
                            res = obj.Add(a, b, c);
                            Console.WriteLine(abc.Item1);
                            Console.WriteLine(abc.Item2);
                            Console.WriteLine("\nResult:" + res);
                            break;
                        case 2:
                            getInput();
                            var xyz=obj.Sub(a, b);
                            
                            res = xyz.Output;
                            //res = obj.Sub(a, b);
                            Console.WriteLine(xyz.FirstNumber);
                            Console.WriteLine(xyz.ResultOutput);
                            Console.WriteLine(xyz.LastNumber);
                            Console.WriteLine("\nResult:" + res);
                            break;
                        case 3:
                            getInput();
                            res = obj.Mul(a, b);
                            Console.WriteLine("\nResult:" + res);
                            break;
                        case 4:
                            getInput();
                            res = obj.Div(a, b);
                            Console.WriteLine("\nResult:" + res);
                            break;
                        case 5:
                            System.Environment.Exit(res);
                            break;
                        default:
                            //res=0;
                            Console.WriteLine("Invalid option choice");
                            break;
                    }
                    Console.WriteLine("\nDo you still want to continue? To continue please enter Y/y");
                    again = char.Parse(Console.ReadLine()).ToString().ToLower();


                } while (again=="y");


            }
            catch (Exception)
            {   
                Console.WriteLine("Error!!! Exception occured");
                
            }
        }
        #endregion

    }
}
