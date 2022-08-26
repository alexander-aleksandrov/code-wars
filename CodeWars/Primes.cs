public static class Primes
{
  public static long SumOfPrimes(int number)
  {
    return GetPrimes(number).Sum();
  }
  public static long PrimeAtNumber(int number)
  {
    long res = 0;
    int counter = 0;
    for (long i = 1; i <= long.MaxValue; i++)
    {
      for (long j = i; j >= 1; j--)
      {
        if (i % j == 0 && j != 1 && i != j)
        {
          break;
        }
        if (j == 1)
        {
          res = i;
          counter++;
        }
      }
      if (counter == number + 1)
        break;
    }
    return res;
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
    list.Add(2);
    for (int i = 3; i <= value; i++)
    {
      int newItem = 0;
      for (int j = 0; j <= list.Count - 1; j++)
      {
        if (i % list[j] == 0)
        {
          break;
        }
        else if (j == list.Count - 1)
        {
          newItem = i;
        }
      }
      if (newItem != 0)
        list.Add(i);
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

