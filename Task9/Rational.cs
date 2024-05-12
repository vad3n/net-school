namespace Task9
{
    public class Rational : IComparable<Rational>
    {
        private int _numerator;
        private int _denominator;

        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0.");
            }

            int gdc = HelperFunctions.GetGdc(Math.Abs(numerator), Math.Abs(denominator));
            _numerator = numerator / gdc;
            _denominator = denominator / gdc;

            if ((_numerator < 0 && _denominator < 0) || (_numerator > 0 && _denominator < 0))
            {
                _numerator *= -1;
                _denominator *= -1;
            }
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Rational;

            if (other == null)
            {
                return false;
            }

            return _numerator == other.Numerator && _denominator == other.Denominator;
        }

        public override int GetHashCode()
        {
            return Math.Abs(_numerator) * 15 + _denominator * 7;
        }

        public override string ToString()
        {
            return _numerator + " / " + _denominator;
        }

        public int CompareTo(Rational? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (this.Equals(other))
            {
                return 0;
            }

            if (_numerator * other.Denominator > _denominator * other.Numerator)
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }

        public static Rational operator +(Rational first, Rational second)
        {
            return new Rational(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public static Rational operator -(Rational first, Rational second)
        {
            return new Rational(first.Numerator * second.Denominator - second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public static Rational operator *(Rational first, Rational second)
        {
            return new Rational(first.Numerator * second.Numerator, first.Denominator * second.Denominator);
        }

        public static Rational operator /(Rational first, Rational second)
        {
            return new Rational(first.Numerator * second.Denominator, first.Denominator * second.Numerator);
        }

        public static explicit operator double(Rational rational)
        {
            return rational.Numerator / (double)rational.Denominator;
        }

        public static implicit operator Rational(int number)
        {
            return new Rational(number, 1);
        }
    }

    internal static class HelperFunctions
    {
        public static int GetGdc(int a, int b)
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }
    }
}
