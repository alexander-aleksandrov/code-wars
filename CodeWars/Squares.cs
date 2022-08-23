
public static class Squares
{
  public static int TheDifference()
  {
    int sumOfSquares = 0;
    int squareOfSums = 0;
    for (int i = 0; i <= 100; i++)
    {
      sumOfSquares += i * i;
      squareOfSums += i;
    }
    squareOfSums *= squareOfSums;

    return squareOfSums - sumOfSquares;
  }
}

