using Calculater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestApp
{
    public class TestLogicCalc
    {
        [Fact]
        public void TestPlus()
        {
            //  Проверяем выдает ли правильный результат действие суммы

            CalculLogic calculation = new CalculLogic();

            string result = calculation.Calculate(1, 5, "5");
            Assert.Equal("10", result);

            result = calculation.Calculate(1, -1, "-1");
            Assert.Equal("-2", result);
        }

        [Fact]
        public void TestMinus()
        {
            //  Проверяем выдает ли правильный результат действие разности

            CalculLogic calculation = new CalculLogic();

            string result = calculation.Calculate(2, 5, "5");
            Assert.Equal("0", result);

            result = calculation.Calculate(2, -1, "-1");
            Assert.Equal("0", result);
        }

        [Fact]
        public void TestMultiply()
        {
            //  Проверяем выдает ли правильный результат действие умножения

            CalculLogic calculation = new CalculLogic();

            string result = calculation.Calculate(3, 5, "5");
            Assert.Equal("25", result);

            result = calculation.Calculate(3, -1, "-1");
            Assert.Equal("1", result);
        }

        [Fact]
        public void TestDiv()
        {
            //  Проверяем выдает ли правильный результат действие деления

            CalculLogic calculation = new CalculLogic();

            string result = calculation.Calculate(4, 5, "5");
            Assert.Equal("1", result);

            result = calculation.Calculate(4, -1, "-1");
            Assert.Equal("1", result);
        }
    }
}
