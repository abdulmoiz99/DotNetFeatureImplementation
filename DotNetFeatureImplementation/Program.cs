var queue = new PriorityQueue<int, int>();
queue.Enqueue(1, 2);
queue.Enqueue(2, 3);
queue.Enqueue(3, 1);
queue.Enqueue(4, 5);


Console.WriteLine(queue.Remove(1, out int value, out _));
Console.WriteLine(value);

//while (queue.Count > 0)
//{
//    Console.WriteLine(queue.Dequeue());
//}
