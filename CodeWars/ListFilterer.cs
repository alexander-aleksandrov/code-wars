﻿public static class ListFilterer
{
  public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
  {
    return listOfItems.OfType<int>();
  }
}

