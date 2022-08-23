
public static class DetectPangram
{
  public static bool IsPangram(string pangram)
  {
    List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    foreach (char c in pangram)
    {
      if (alphabet.Contains(Char.ToLower(c)))
      {
        alphabet.Remove(Char.ToLower(c));
      }
    }

    int v = alphabet.Count();
    Console.WriteLine(v);
    return v == 0 ? true : false;
  }
}
