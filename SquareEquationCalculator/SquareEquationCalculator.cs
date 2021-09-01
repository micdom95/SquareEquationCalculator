using System;
using System.Collections.Generic;
using System.Text;

namespace SquareEquation
{
    public class SquareEquationCalculator
    {
        public string message;
        public int rootCounter;
        public double a, b, c;
        public double delta, denominator=1, x1, x2;
        
        public SquareEquationCalculator()
        {
            
        }

        public void CalculateSquareEquation(double a, double b, double c)
        {
            if (a != 0)
            {
                delta = Math.Pow(b,2) - (4 * a * c);
                denominator = 2 * a;
                
                if (delta > 0)
                {
                    x1 = (-b / denominator) + (Math.Sqrt(delta) / denominator);
                    x2 = (-b / denominator) - (Math.Sqrt(delta) / denominator);
                    message = "Function with two roots";
                    rootCounter = 2;
                }
                else if (delta == 0)
                {
                    x1 = -b / denominator;
                    message = "Function with one root";
                    rootCounter = 1;
                }
                else
                {
                    message = "Function without roots";
                    rootCounter = 0;
                }
            }
            else
            {
                message = "Exception: Divided by 0";
                denominator = 0;
            }
        }
    }
}
