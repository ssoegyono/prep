using System;
using System.Data;

namespace prep.calculator
{
    public class Calculator
    {

        public Calculator(IDbConnection connection)
        {
            connection.Open();
        }

        public int add(int i, int i1)
        {
            if (i * i1 < 0)
                throw new ArgumentException();

            return i + i1;
        }
    }
}