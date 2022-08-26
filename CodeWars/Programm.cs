public class Programm
{
  public static void Main()
  {
    int sum = 1;
    foreach (int div in Primes.UniqueMultipliers(20))
    {
      Console.WriteLine(div);
      sum *= div;
    }
    Console.WriteLine(sum);
  }

}
