using ExamplePOO.interfaces;

namespace ExamplePOO.Models
{
    public class Calculator : iCalculator
    {
        public double Divide(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException();
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Pow(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double Sqrt(double num1)
        {
            return Math.Sqrt(num1);
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}