using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks; 

namespace Calculater
{
    public class CalculLogic
    {
        public string Calculate(int count, double a, string c)
        {
            // Наборы команд для арифметических действий

            double b = 0;

            switch (count)
            {
                case 1:
                    b = a + double.Parse(c);
                    return b.ToString();

                case 2:
                    b = a - double.Parse(c);
                    return b.ToString();

                case 3:
                    b = a * double.Parse(c);
                    return b.ToString();

                case 4:

                    if (double.Parse(c) == 0)
                    {
                        return "NOT ÷ 0";
                    }

                    else
                    {
                        b = a / double.Parse(c);
                        return b.ToString();
                    }

                default:
                    break;
            }
            return "0";
        }
    }
}
