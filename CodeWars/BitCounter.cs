public static class BitCounter
{
  public static int CountBits(int n)
  {
    int sum = 0;
    string str = Convert.ToString(12, 2);
    for (int i = 0; i < str.Length; i++)
    {
      if (str[i] == '1')
      {
        sum++;
      }
    }
    return sum;
  }
}
