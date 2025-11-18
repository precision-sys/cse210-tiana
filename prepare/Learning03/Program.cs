using System;


class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.MakeFraction());
        Console.WriteLine(fraction1.MakeDecimal());

       
    }

    class Fraction
       {
        private int _top;
        private int _bottom;

        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }
        
        public int GetBottom()
        {
            return _bottom;
        }
        
        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }


        public Fraction()
        {
             _top = 1;
             _bottom = 1;
        }

        public Fraction(int aTop, int aBottom)
        {
             _top = aTop;
             _bottom = aBottom;
        }

        public Fraction (int number )
        {
            _top = number;
            _bottom = 1;
        }
            

        public string MakeFraction()
        {
            return $"{_top}/{_bottom}";
        }

        public double MakeDecimal()
        {
            return (double) _top / (double) _bottom;
        }


        }

}


        

        



