namespace Calculator
{
    public class Math : IMath
    {
        public double Add(double a, double b) => a + b;

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("You can't divide by zero!");
            }

            return a / b;
        }

        public double Mul(double a, double b) => a * b;

        public double Sub(double a, double b) => a - b;
    }
}
