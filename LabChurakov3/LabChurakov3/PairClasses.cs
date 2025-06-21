using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChurakov3
{
    // Абстрактний базовий клас
    public abstract class Pair
    {
        public abstract Pair Add(Pair other);
        public abstract Pair Subtract(Pair other);
        public abstract Pair Multiply(Pair other);
        public abstract Pair Divide(Pair other);
    }

    // Комплексні числа
    public class Complex : Pair
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public Complex(double real = 0, double imag = 0)
        {
            Real = real;
            Imag = imag;
        }

        public override Pair Add(Pair other)
        {
            if (other is Complex c)
                return new Complex(Real + c.Real, Imag + c.Imag);
            throw new ArgumentException("Operand is not Complex");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is Complex c)
                return new Complex(Real - c.Real, Imag - c.Imag);
            throw new ArgumentException("Operand is not Complex");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is Complex c)
                return new Complex(
                    Real * c.Real - Imag * c.Imag,
                    Real * c.Imag + Imag * c.Real
                );
            throw new ArgumentException("Operand is not Complex");
        }

        public override Pair Divide(Pair other)
        {
            if (other is Complex c)
            {
                double denom = c.Real * c.Real + c.Imag * c.Imag;
                if (denom == 0) throw new DivideByZeroException();
                return new Complex(
                    (Real * c.Real + Imag * c.Imag) / denom,
                    (Imag * c.Real - Real * c.Imag) / denom
                );
            }
            throw new ArgumentException("Operand is not Complex");
        }

        // Оператори для зручності
        public static Complex operator +(Complex a, Complex b) => (Complex)a.Add(b);
        public static Complex operator -(Complex a, Complex b) => (Complex)a.Subtract(b);
        public static Complex operator *(Complex a, Complex b) => (Complex)a.Multiply(b);
        public static Complex operator /(Complex a, Complex b) => (Complex)a.Divide(b);

        public override string ToString()
        {
            string sign = Imag >= 0 ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imag)}i";
        }
    }

    // Раціональні дроби
    public class Rational : Pair
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Rational(int num = 0, int den = 1)
        {
            if (den == 0) throw new ArgumentException("Denominator cannot be zero");
            Numerator = num;
            Denominator = den;
            Simplify();
        }

        private void Simplify()
        {
            int g = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= g;
            Denominator /= g;
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public override Pair Add(Pair other)
        {
            if (other is Rational r)
                return new Rational(
                    Numerator * r.Denominator + r.Numerator * Denominator,
                    Denominator * r.Denominator
                );
            throw new ArgumentException("Operand is not Rational");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is Rational r)
                return new Rational(
                    Numerator * r.Denominator - r.Numerator * Denominator,
                    Denominator * r.Denominator
                );
            throw new ArgumentException("Operand is not Rational");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is Rational r)
                return new Rational(Numerator * r.Numerator, Denominator * r.Denominator);
            throw new ArgumentException("Operand is not Rational");
        }

        public override Pair Divide(Pair other)
        {
            if (other is Rational r)
            {
                if (r.Numerator == 0) throw new DivideByZeroException();
                return new Rational(Numerator * r.Denominator, Denominator * r.Numerator);
            }
            throw new ArgumentException("Operand is not Rational");
        }

        public static Rational operator +(Rational a, Rational b) => (Rational)a.Add(b);
        public static Rational operator -(Rational a, Rational b) => (Rational)a.Subtract(b);
        public static Rational operator *(Rational a, Rational b) => (Rational)a.Multiply(b);
        public static Rational operator /(Rational a, Rational b) => (Rational)a.Divide(b);

        public override string ToString() => $"{Numerator}/{Denominator}";
    }

}
