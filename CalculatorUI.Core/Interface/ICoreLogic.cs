using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Core.Interface
{
    public interface ICoreLogic
    {
        double PerformCalculation(double firstValue, double secondValue, string operation);
        double PerformCommonCalculation(double firstValue, string operation);
    }
}
