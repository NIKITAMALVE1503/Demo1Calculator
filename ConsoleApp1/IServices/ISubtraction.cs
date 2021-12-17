using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.IServices
{
    internal interface ISubtraction
    {
        public ResultsSubtraction Sub(int a, int b);
    }
}
