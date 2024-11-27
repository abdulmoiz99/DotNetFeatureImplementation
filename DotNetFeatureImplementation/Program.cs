var dictionay = new OrderedDictionary<int, string>();

dictionay.Add(3, "Test3");
dictionay.Add(1, "Test1");
dictionay.Add(2, "Test2");
dictionay.Add(4, "Test4");

foreach(var item in dictionay)
{
    Console.WriteLine("{0}--{1}", item.Key, item.Value);
}

dictionay.RemoveAt(0);

foreach (var item in dictionay)
{
    Console.WriteLine("{0}--{1}", item.Key, item.Value);
}
