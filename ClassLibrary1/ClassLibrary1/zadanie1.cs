using System;

namespace ClassLibrary1
{
    public partial class drobi
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public drobi(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            if (Denominator == 0)
            {
                Console.WriteLine("Denominator = 0");
                Environment.Exit(0);
            }
        }

        private (int, int) chet() {
            for (int i = Numerator; i > 0; i--)
            {
                if (Numerator % i == 0 && Denominator % i == 0)
                {
                    Numerator = Numerator / i;
                    Denominator = Denominator / i;
                }
            }
            return (Numerator, Denominator);

        }
        public string Tostring() {
            if (Numerator < 0 && Denominator < 0) {
                Numerator = -Numerator;
                Denominator = -Denominator;
                (Numerator, Denominator) = chet();
                return $"{Numerator}/{Denominator}";
            }
            if (Numerator < 0)
            {
                Numerator = -Numerator;
                (Numerator, Denominator) = chet();
                return $"-{Numerator}/{Denominator}";
            }
            if (Denominator < 0)
            {
                Denominator = -Denominator;
                (Numerator, Denominator) = chet();
                return $"-{Numerator}/{Denominator}";
            }
            (Numerator, Denominator) = chet();
            return $"{Numerator}/{Denominator}";
        }

    }
}