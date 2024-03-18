namespace ClassLibrary1
{
    public partial class drobi
    {
        private drobi ToClass()
        {
            if (Numerator < 0 && Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
                (Numerator, Denominator) = chet();
                return new drobi(Numerator, Denominator);
            }
            if (Numerator < 0)
            {
                Numerator = -Numerator;
                (Numerator, Denominator) = chet();
                return new drobi(-Numerator, Denominator);
            }
            if (Denominator < 0)
            {
                Denominator = -Denominator;
                (Numerator, Denominator) = chet();
                return new drobi(-Numerator, Denominator);
            }
            (Numerator, Denominator) = chet();
            return new drobi(Numerator, Denominator);


        }
        public static drobi operator +(drobi x, drobi y)
        {
            drobi a = new drobi(x.Numerator * y.Denominator + y.Numerator * x.Denominator, x.Denominator * y.Denominator);
            return a.ToClass();
        }

        public static drobi operator -(drobi x, drobi y)
        {
            drobi a = new drobi(x.Numerator * y.Denominator - y.Numerator * x.Denominator, x.Denominator * y.Denominator);
            return a.ToClass();
        }

        public static drobi operator *(drobi x, drobi y)
        {
            drobi a = new drobi(x.Numerator * y.Numerator, x.Denominator * y.Denominator);
            return a.ToClass();
        }

        public static drobi operator /(drobi x, drobi y)
        {
            drobi a = new drobi(x.Numerator * y.Denominator, x.Denominator * y.Numerator);
            return a.ToClass();
        }

        public static drobi operator -(drobi x)
        {
            drobi a = new drobi(-x.Numerator, x.Denominator);
            return a.ToClass();
        }
    }
}
