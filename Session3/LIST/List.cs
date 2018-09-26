using System;
using System.Collections.Generic;

public static class Lists{
public static T RandomItem<T>(this List<T> list)
{
    Random random = new Random();
    return list[random.Next(0,list.Count)];
}
}