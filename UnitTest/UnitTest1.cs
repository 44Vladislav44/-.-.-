using System;
using System.Linq;
using Xunit;
using Calculater.Logic_Calc;

namespace UnitTest
{
    public class UnitTest1
    { 
        [Fact]
        public void TestSum()
        {
            Logic_Calc calculation = new();
            string = calculation.Calculate(1, 5, 6);
            Assert.Equal("11", result);
        
    }
}
