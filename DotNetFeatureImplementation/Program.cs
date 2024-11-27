var stringPara = "Paragraphs are the building blocks of papers. Many students define paragraphs in terms of length: a paragraph is a group of at least five sentences, a paragraph is half a page long, etc. In reality, though, the unity and coherence of ideas among sentences is what constitutes a paragraph";

var result = CountWords(stringPara);

foreach (var value in result)
{
    Console.WriteLine("{0} - {1}", value.Key, value.Value);
}

static Dictionary<string, int> CountWords(ReadOnlySpan<char> para)
{
    Dictionary<string, int> wordCounts = new(StringComparer.OrdinalIgnoreCase);
    Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> spanLookUp =
        wordCounts.GetAlternateLookup<ReadOnlySpan<char>>();

    foreach (Range wordRange in para.Split(' '))
    {
        ReadOnlySpan<char> word = para[wordRange];
        spanLookUp[word] = spanLookUp.TryGetValue(word, out int count) ? count + 1 : 1;
    }
    return wordCounts;
}