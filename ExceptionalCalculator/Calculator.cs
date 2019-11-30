using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalCalculator
{
    public class Calculator
    {
        public double Value { get; private set; }
        public void Add(double val)
        {
            Value += val;
        }
    }
}
