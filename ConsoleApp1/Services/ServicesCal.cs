using ConsoleApp1.IServices;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Services
{
    internal class ServicesCal: IAddition, IDivision, IMultiplication, ISubtraction
    {
        public Tuple<int,int,int> Add(int a, int b)
        {
            try
            {
                return new Tuple<int, int, int>(a,b,a+b);
            }
            catch (Exception)
            {
                return new Tuple<int, int, int>(a,b,0);
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
        public ResultsSubtraction Sub(int a, int b)
        {
            try
            {
                ResultsSubtraction res = new ResultsSubtraction();
                res.FirstNumber = a;
                res.LastNumber = b;
                res.Output = a - b;
                res.ResultOutput = (a-b).ToString();
                
                return res;

                //return a - b;
            }
            catch( Exception)
            {
                throw;
            }
        }

    }
}
