namespace prep
{
  public class Calculator
  {
    public static int add(int first, int second)
    {
        //if ((first < 0 && second >= 0) || (first >= 0 && second < 0))
        //    throw new ArgumentException();

        if (Math.Sign(first) != Math.Sign(second);
            throw new ArgumentException();

        return first + second;

    }
  }
}