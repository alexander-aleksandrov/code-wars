public class Programm
{
  public static void Main()
  {
    Console.WriteLine(GetLongest(new[] { "azaz", "as", "sdsd" }));
    Console.WriteLine(GetLongest(new[] { "zzzz", "as", "sdsd" }));
    Console.WriteLine(GetLongest(new[] { "as", "12345", "as", "sds" }));
  }

  private static string GetLongest(string[] arr)
  {
    var res = arr.OrderByDescending(x => x.Length).ToArray();
    return res[0];
  }
}
