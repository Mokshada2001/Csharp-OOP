using System;

namespace OOPS
{
    class Encapsulation
    {
        // Encapsulation Begin
        int x;
        //class constructor
        public Encapsulation(int iX)
        {
            this.x = iX;
        }
        //calculating the square
        public void MySquare()
        {
            int Calc = x * x;
            Console.WriteLine(Calc);
        }
    // End of Encapsulation
    }
}

