using System;

namespace Week2.Classes
{
    public class Complex
    {
        #region enums

        public enum PrintFormat
        {
            Readable,   // a + bi
            Vector      // (a, b)
        }

        #endregion

        #region ctor
        public Complex() : this(0,0) { }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex(string complexNumber)
        {
            string cleanString = complexNumber
                .Substring(1, complexNumber.Length - 2);
            string[] numberParts = cleanString.Split(',');

            Real = GetDoubleValue(numberParts[0]);
            Imaginary = GetDoubleValue(numberParts[1]);
        }

        #endregion

        #region Properties

        public double Real { get; set; }
        public double Imaginary { get; set; }

        private Complex Conjugate
        {
            get
            {
                return new Complex(Real, -Imaginary);
            }
        }

        public double Module
        {
            get
            {
                return Math.Sqrt(
                    Math.Pow(Real, 2) + 
                    Math.Pow(Imaginary, 2));
            }
        }

        #endregion

        #region Operator Overload

        public static Complex operator-(Complex c)  // Conjugate
        {
            return c.Conjugate;
        }

        public static Complex operator+(Complex c1, Complex c2)
        {
            return c1.Sum(c2);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return c1.Subtract(c2);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return c1.Multiply(c2);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            return c1.Subtract(c2);
        }

        #endregion

        #region Class Properties

        public static Complex AdditionNeutral = new Complex(0, 0);
        public static Complex MultiplyNeutral = new Complex(1, 0);

        #endregion

        #region Methods

        private Complex Sum(Complex op)
        {
            return new Complex(
                Real + op.Real,
                Imaginary + op.Imaginary
            );
        }

        private Complex Subtract(Complex op)
        {
            return new Complex(
                Real - op.Real,
                Imaginary - op.Imaginary
            );
        }

        private Complex Multiply(Complex op)
        {
            double real = Real * op.Real 
                - Imaginary * op.Imaginary;
            double imaginary = Real * op.Imaginary 
                + Imaginary * op.Real;

            return new Complex(real, imaginary);
        }

        private Complex Divide(Complex op)
        {
            double real = (Real * op.Real + Imaginary * op.Imaginary) / 
                (Math.Pow(op.Real, 2) + Math.Pow(op.Imaginary, 2));

            double imaginary = (Imaginary * op.Real - Real * op.Imaginary) /
                (Math.Pow(op.Real, 2) + Math.Pow(op.Imaginary, 2));

            return new Complex(real, imaginary);
        }

        public string Print(PrintFormat format)
        {
            string result = string.Empty;

            switch (format)
            {
                case PrintFormat.Readable:
                    result = string.Format(
                        "{0} {1} {2}i", 
                        Real, 
                        Imaginary > 0 ? "+" : "-",
                        Math.Abs(Imaginary));
                    break;
                case PrintFormat.Vector:
                    result = string.Format("({0}, {1})", Real, Imaginary);
                    break;
                default:
                    result = "Format Unkwown.";
                    break;
            }

            return result;
        }

        #endregion

        #region Class Methods

        public static Complex CreateComplex(double real, double imaginary)
        {
            return new Complex(real, imaginary);
        }

        #endregion

        #region Support Method

        private double GetDoubleValue(string numberParts)
        {
            double temp;
            double.TryParse(numberParts, out temp);

            return temp;
        }

        #endregion

    }
}
