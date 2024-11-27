var value = new Coords();
Console.WriteLine(value.x);
Console.WriteLine(value.y);


public readonly struct Coords
{
    public int x { get; init; }
    public int y { get; init; }
}