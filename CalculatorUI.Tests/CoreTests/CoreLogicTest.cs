using CalculatorUI.Core.Classes;
using CalculatorUI.Core.Core;
using CalculatorUI.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Tests.CoreTests
{
    public class CoreLogicTest
    {
        [SetUp]
        public void Setup()
        {
            
        }
        public ICoreLogic ScenarioSetUp()
        {
            ICommonArithmaticOps commonOps = new CommonArithmaticOps();
            return new Corelogic(commonOps);
        }
        [Test]
        public void PerformCalculationTest()
        {
            var coreLogic = ScenarioSetUp();
            double op = 0;

            //Scenario1
             op= coreLogic.PerformCalculation(5, 6, "+");
            Assert.IsTrue(op > 0);
            //Scenario2
            op = coreLogic.PerformCalculation(5, 6, "-");
            Assert.IsTrue(op < 0);
            //Scenario3
            op = coreLogic.PerformCalculation(5, 6, "×");
            Assert.IsTrue(op==30);
            //Scenario4
            op = coreLogic.PerformCalculation(6, 6, "÷");
            Assert.IsFalse(op == 0);

        }
        [Test]
        public void PerformCommonCalculationTest()
        {
            var coreLogic = ScenarioSetUp();
            double op = 0;

            //Scenario1
            op = coreLogic.PerformCommonCalculation(6, "1/x");
            Assert.IsTrue(op > 0);
            //Scenario2
            op = coreLogic.PerformCommonCalculation(6, "×²");
            Assert.IsTrue(op > 0);
            //Scenario3
            op = coreLogic.PerformCommonCalculation(6, "²√x");
            Assert.IsTrue(op >0);
            //Scenario4
            op = coreLogic.PerformCommonCalculation(6, "%");
            Assert.IsTrue(op> 0);

            op = coreLogic.PerformCommonCalculation(-6, "%");
            Assert.IsTrue(op < 0);

        }
    }
}
