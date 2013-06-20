using System;

namespace prep.calculator
{
    public class Calculator
    {
        public int add(int i, int i1)
        {
           if (Math.Sign(i) != Math.Sign(i1))
               throw new ArgumentException();

            return i + i1;

        }
    }
}