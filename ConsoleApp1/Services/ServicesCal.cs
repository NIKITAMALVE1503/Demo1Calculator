using ConsoleApp1.IServices;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Services
{
    internal class ServicesCal: IAddition, IDivision, IMultiplication, ISubtraction
    {
        public int Add(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int Add(int a, int b, int c)
        {
            try
            {
                return a+b+c;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Div(int a, int b)
        {
                        
            try
            {
                if(b==0)
                    throw Exception();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return a/b;
            

        }

        private Exception Exception()
        {
            throw new DivideByZeroException();
            
        }

        public int Mul(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch(Exception)
            {
                return -1;
            }
           
        }
        public int Sub(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch( Exception)
            {
                throw;
            }
        }

    }
}
