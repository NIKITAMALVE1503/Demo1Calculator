using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.IServices
{
    internal interface IAddition
    {
        public  Tuple<int, int,int> Add(int a, int b);
    }
}
