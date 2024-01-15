using CalculatorUI.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Core.Core
{
    public class Corelogic : ICoreLogic
    {
        private readonly ICommonArithmaticOps _iCommonArtimaticOps;
        public Corelogic(ICommonArithmaticOps iCommonArtimaticOps) 
        {
        _iCommonArtimaticOps = iCommonArtimaticOps;
        }
        public double PerformCalculation(double firstValue, double secondValue, string operation)
        {
            switch (operation)
            {
                case "+":
                    return firstValue + secondValue;
                case "-":
                    return firstValue - secondValue;
                case "×":
                    return firstValue * secondValue;
                case "÷":
                    return firstValue / secondValue;
                default:
                    return 0;
            }
        }

        public double PerformCommonCalculation(double firstValue, string operation)
        {
            if (firstValue!=0)
            {
                switch (operation)
                {
                    case "1/x":
                        return _iCommonArtimaticOps.CalculateOneDivsibleByX(firstValue.ToString());
                    case "×²":
                        return _iCommonArtimaticOps.CalculateSuqare(firstValue.ToString());
                    case "²√x":
                        return _iCommonArtimaticOps.CalculateSuqareRoot(firstValue.ToString());
                    case "%":
                        return _iCommonArtimaticOps.CalculatePercentage(firstValue.ToString());
                    case "±":
                        return _iCommonArtimaticOps.CalculatePlusMinus(firstValue.ToString());
                    default:
                        return 0;
                }
            }
            else
            {
                return 0;
            }
            
        }
    }
}
