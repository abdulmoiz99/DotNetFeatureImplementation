TimeSpan timespan1 = TimeSpan.FromSeconds(value: 101.832);
Console.WriteLine(timespan1); // since the value is in double its it represented wrong // timeSpan1 = 00:01:41.8319999

TimeSpan timespan2 = TimeSpan.FromSeconds(seconds: 101, milliseconds: 832);
Console.WriteLine(timespan2); // this one is correct and more precise timeSpan2 = 00:01:41.8320000