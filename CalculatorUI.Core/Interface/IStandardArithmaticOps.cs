using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Core.Interface
{
    public interface IStandardArithmaticOps
    {
        string Add(double firstValue,double lastValue);
        string Subtract(double firstValue, double lastValue);
        string Multiply(double firstValue, double lastValue);
        string Divide(double firstValue, double lastValue);

    }
}
