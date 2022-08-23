public class Problem2
{
  public void FibonachiEvenSum()
  {
    int sum = 0;
    int item = 1;
    List<int> list = new List<int>();
    list.Add(item);
    while (item < 4000000)
    {
      int lastItem = list.Last();
      list.Add(item + lastItem);
      item = list[list.Count - 2];
    }
    list.RemoveAt(list.Count - 1);
    sum = list.Where(n => n % 2 == 0).Sum();
    Console.WriteLine(sum);
  }
}

