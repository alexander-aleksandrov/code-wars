public static class Primes
{
  public static long PrimeAtNumber(int number)
  {
    var list = new List<long>();
    for (long i = 1; i <= long.MaxValue; i++)
    {
      for (long j = i; j >= 1; j--)
      {
        if (i % j == 0 && j != 1 && i != j)
        {
          break;
        }
        if (j == 1)
          list.Add(i);
      }
      if (list.Count == number + 1)
        break;
    }
    return list.Last();
  }
  public static List<int> UniqueMultipliers(int value)
  {
    List<int> list = new List<int>();
    for (int i = 1; i <= value; i++)
    {
      var divList = Primes.PrimeDividers(i);
      foreach (int item in list)
      {
        divList.Remove(item);
      }

      if (divList.Count != 0)
      {
        list.Add(divList.Last());
      }
      else
      {
        continue;
      }
    }
    return list;
  }

  public static List<int> PrimeDividers(int value)
  {
    List<int> primes = GetPrimes(value);
    List<int> divisors = new List<int>();
    for (int i = primes.Count - 1; i >= 0; i--)
    {
      if (value % primes[i] == 0 && value != 1)
      {
        divisors.Add(primes[i]);
        value /= primes[i];
        i++;
      }
    }
    return divisors;
  }

  public static List<int> GetPrimes(int value)
  {
    var list = new List<int>();
    for (int i = 1; i <= value; i++)
    {
      for (int j = i; j >= 1; j--)
      {
        if (i % j == 0 && j != 1 && i != j)
        {
          break;
        }
        if (j == 1)
          list.Add(i);
      }
    }
    return list;
  }
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

