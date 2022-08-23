public static class YourOrder
{
  public static string Order(string str)
  {
    string[] words = str.Split(" ");
    int[] wordIndexes = new int[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
      if (words[i].Any(Char.IsDigit))
      {
        string number = new string(words[i].Where(Char.IsDigit).ToArray());
        wordIndexes[i] = Int32.Parse(number);
      }
    }
    for (int i = 0; i < wordIndexes.Length; i++)
    {
      for (int j = 0; j < wordIndexes.Length - 1; j++)
      {
        if (wordIndexes[j] > wordIndexes[j + 1])
        {
          int tempIndex = wordIndexes[j];
          wordIndexes[j] = wordIndexes[j + 1];
          wordIndexes[j + 1] = tempIndex;

          string word = words[j];
          words[j] = words[j + 1];
          words[j + 1] = word;
        }
      }
    }

    string v = string.Join(" ", words);
    Console.WriteLine(v);
    return v;
  }
}
