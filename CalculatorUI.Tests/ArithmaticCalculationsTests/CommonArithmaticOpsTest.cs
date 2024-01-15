using CalculatorUI.Core.Classes;
using CalculatorUI.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI.Tests.ArithmaticCalculationsTests
{
    public class CommonArithmaticOpsTest
    {
        public ICommonArithmaticOps ScenarioSetUp()
        {
            return new CommonArithmaticOps();
        }
        [Test]
        public void CalculateModularDivTest()
        {
            var commonArtOps = ScenarioSetUp();
            Assert.IsTrue(commonArtOps.CalculateModularDiv(5, 2) > 0);
        }
        [Test]
        public void CalculateOneDivsibleByXTest()
        {
            var commonArtOps = ScenarioSetUp();
            Assert.IsTrue(commonArtOps.CalculateOneDivsibleByX("5") > 0);
        }
        [Test]
        public void CalculatePercentageTest()
        {
            var commonArtOps = ScenarioSetUp();
            Assert.IsTrue(commonArtOps.CalculatePercentage("5") > 0);
        }
        [Test]
        public void CalculatePlusMinusTest()
        {
            var commonArtOps = ScenarioSetUp();
            Assert.IsTrue(commonArtOps.CalculatePlusMinus("5") < 0);
        }
        [Test]
        public void CalculateSuqareTest()
        {
            var commonArtOps = ScenarioSetUp();
            Assert.IsTrue(commonArtOps.CalculateSuqare("5") > 0);
        }
        [Test]
        public void CalculateSuqareRootTest()
        {
            var commonArtOps = ScenarioSetUp();
            Assert.IsTrue(commonArtOps.CalculateSuqareRoot("25") > 0);
        }
    }
}
