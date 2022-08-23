public static class Palindrome
{
  public static int BigestPalindrome()
  {
    List<int> answers = new List<int>();
    for (int i = 100; i < 999; i++)
    {
      for (int j = 100; j < 999; j++)
      {
        if (IsPalindrome(i * j))
        {
          answers.Add(i * j);
        }
      }
    }
    return answers.Max();
  }

  private static bool IsPalindrome(int value)
  {
    char[] reversedString = value.ToString().ToCharArray();
    Array.Reverse(reversedString);
    int reversedValue = Int32.Parse(reversedString);
    if (reversedValue == value)
    {
      return true;
    }
    return false;
  }
}
