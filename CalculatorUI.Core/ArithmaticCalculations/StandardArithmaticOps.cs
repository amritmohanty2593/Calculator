using CalculatorUI.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Core.Classes
{
    public class StandardArithmaticOps : IStandardArithmaticOps
    {
        public string Add(double firstValue, double lastValue)
        {
            return (firstValue + lastValue).ToString();
        }

        public string Divide(double firstValue, double lastValue)
        {
            return (firstValue / lastValue).ToString();
        }

        public string Multiply(double firstValue, double lastValue)
        {
            return (firstValue * lastValue).ToString();
        }

        public string Subtract(double firstValue, double lastValue)
        {
            return (firstValue - lastValue).ToString();
        }
    }
}
