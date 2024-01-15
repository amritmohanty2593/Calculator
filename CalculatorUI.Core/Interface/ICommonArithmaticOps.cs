using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Core.Interface
{
    public interface ICommonArithmaticOps
    {
        double CalculatePercentage(string textValue);
        double CalculateSuqareRoot(string textValue);
        double CalculateSuqare(string textValue);
        double CalculateOneDivsibleByX(string textValue);
        double CalculateModularDiv(double textValue,double secondTextValue);
        double CalculatePlusMinus(string textValue);

    }
}
