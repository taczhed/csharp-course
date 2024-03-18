using System;


namespace test.Object.Lab01
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        public int numerator;
        public int denominator;

        public Fraction(int initNumerator, int initDenominator)
        {
            if (initDenominator == 0) throw new ArgumentException("Invalid denominator");
            numerator = initNumerator;
            denominator = initDenominator;
            Simplify();
        }

        public void Simplify()
        {
            int a = numerator;
            int b = denominator;

            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }

            numerator = numerator / a;
            denominator = denominator / a;
        }

        public override string ToString()
        {
            return numerator.ToString() + '/' + denominator.ToString();
        }

        public static Fraction operator +(Fraction n1, Fraction n2)
        {
            int currNum1 = n1.numerator * n2.denominator;
            int currNum2 = n2.numerator * n1.denominator;
            int currDen = n1.denominator * n2.denominator;
            return new Fraction(currNum1 + currNum2, currDen);
        }

        public static Fraction operator -(Fraction n1, Fraction n2)
        {
            int currNum1 = n1.numerator * n2.denominator;
            int currNum2 = n2.numerator * n1.denominator;
            int currDen = n1.denominator * n2.denominator;
            return new Fraction(currNum1 - currNum2, currDen);
        }

        public static Fraction operator *(Fraction n1, Fraction n2)
        {
            return new Fraction(n1.numerator * n2.numerator, n1.denominator * n2.denominator);
        }

        public static Fraction operator /(Fraction n1, Fraction n2)
        {
            return new Fraction(n1.numerator * n2.denominator, n1.denominator * n2.numerator);
        }

        //public static bool operator ==(Fraction n1, Fraction n2)
        //{
        //    double cn1 = n1.numerator / n1.denominator;
        //    double cn2 = n2.numerator / n2.denominator;
        //    return cn1 == cn2;
        //}

        //public static bool operator !=(Fraction n1, Fraction n2)
        //{
        //    double cn1 = n1.numerator / n1.denominator;
        //    double cn2 = n2.numerator / n2.denominator;
        //    return cn1 == cn2;
        //}

        public bool Equals(Fraction other)
        {
            if (other == null) return false;
            Simplify();
            var tempOther = new Fraction(other.numerator, other.denominator);
            return numerator == tempOther.numerator && denominator == tempOther.denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            return Equals((Fraction)obj);
        }

        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }

        public int CompareTo(Fraction other)
        {
            Simplify();
            var tempOther = new Fraction(other.numerator, other.denominator);
            double cn1 = (double)numerator / denominator;
            double cn2 = (double)tempOther.numerator / tempOther.denominator;
            return cn1.CompareTo(cn2);
        }
    }

    public static class FractionExtensions
    {
        public static Fraction Inverse(this Fraction fraction)
        {
            return new Fraction(fraction.denominator, fraction.numerator);
        }
    }
}
