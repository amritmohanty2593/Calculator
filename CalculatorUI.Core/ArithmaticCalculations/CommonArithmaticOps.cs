using CalculatorUI.Core.Interface;
using CalculatorUI.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Core.Classes
{
    public class CommonArithmaticOps : ICommonArithmaticOps
    {
        
        public double CalculateModularDiv(double textValue, double secondTextValue)
        {
            return (textValue % secondTextValue);
        }

        public double CalculateOneDivsibleByX(string textValue)
        {
            return (1 / textValue.ToDouble());
        }

        public double CalculatePercentage(string textValue)
        {
            return (textValue.ToDouble()/"100".ToDouble());
        }

        public double CalculatePlusMinus(string textValue)
        {
            return (-1 * textValue.ToDouble());
        }

        public double CalculateSuqare(string textValue)
        {
            return (textValue.ToDouble() * textValue.ToDouble());
        }

        public double CalculateSuqareRoot(string textValue)
        {
            return Math.Sqrt(textValue.ToDouble());
        }
    }
}
