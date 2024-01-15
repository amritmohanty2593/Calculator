using CalculatorUI.Core.Classes;
using CalculatorUI.Core.Interface;
using CalculatorUI.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Tests.ArithmaticCalculationsTests
{
    public class StandardArithmaticOpsTest
    {
        public IStandardArithmaticOps ScenarioSetUp()
        {
            return new StandardArithmaticOps();
        }
        [Test]
        public void AddTest()
        {
            var stdArthOps = ScenarioSetUp();
            Assert.IsTrue(stdArthOps.Add(5,6).ToDouble() > 0);
        }
        [Test]
        public void DivideTest()
        {
            var stdArthOps = ScenarioSetUp();
            Assert.IsTrue(stdArthOps.Divide(6,6).ToDouble() > 0);
        }
        [Test]
        public void MultiplyTest()
        {
            var stdArthOps = ScenarioSetUp();
            Assert.IsTrue(stdArthOps.Multiply(5, 6).ToDouble() > 0);
        }
        [Test]
        public void SubtractTest()
        {
            var stdArthOps = ScenarioSetUp();
            Assert.IsTrue(stdArthOps.Subtract(5, 6).ToDouble() < 0);
        }
    }
}
