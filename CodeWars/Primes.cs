public static class Primes
{
  public static int GreatestPrimeFactor(long number)
  {
    int divisor = 2;
    while (number > 1)
    {
      if (0 == (number % divisor))
      {
        number /= divisor;
        divisor--;
      }
      divisor++;
    }
    return divisor;
  }
}

