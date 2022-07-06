using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Methods
    {
        public static double Add(int a, int b)
        {
            return a + b;
        }
        public static double Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Multiply(int a, int b)
        {
            return a * b;
            
        }
        public static double Divide(int a, int b)
        {
            return a / b;
        }
        public static double Modulus(int a, int b)
        {
            return a % b;
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
