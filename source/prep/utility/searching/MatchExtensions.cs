﻿namespace prep.utility.searching
{
  public static class MatchExtensions
  {
    public static IMatchA<Item> or<Item>(this IMatchA<Item> left_side, IMatchA<Item> right_side)
    {
      return new OrMatch<Item>(left_side, right_side);
    }

    public static IMatchA<T> not<T>(this IMatchA<T> match)
    {
      return new NegatingMatch<T>(match);
    }
  }
}