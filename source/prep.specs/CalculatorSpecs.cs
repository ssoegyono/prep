﻿using Machine.Specifications;

namespace prep.specs
{
  public class CalculatorSpecs
  {
    public class when_adding_two_numbers
    {
      static int result;

      Because b = () =>
        result = Calculator.add(2, 3);

      It should_return_the_sum = () =>
        result.ShouldEqual(5);

    }


  }
}