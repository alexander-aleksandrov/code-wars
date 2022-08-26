public class Programm
{
  public static void Main()
  {
    var list = new List<int>();
    for (int i = 0; i < 10; i++)
    {
      for (int j = 1; j <= 10; j++)
      {
        if (i % j != 0)
          break;
        if (j == 10)
        {
          list.Add(i);
          return;
        }
      }
      if (list.Count > 0)
      {
        break;
      }
    }
    Console.WriteLine(list[0]);
    Console.ReadLine();
  }

}
