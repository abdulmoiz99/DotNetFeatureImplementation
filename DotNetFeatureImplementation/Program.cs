// Original data
using System.Buffers.Text;
using System.Text;

string originalText = "Hello, Base64Url!";
byte[] data = Encoding.UTF8.GetBytes(originalText);

// Encoding to Base64Url
string encoded = Base64Url.EncodeToString(data);
Console.WriteLine($"Encoded: {encoded}");

// Decoding back to original data
byte[] decodedData = Base64Url.DecodeFromChars(encoded);
string decodedText = Encoding.UTF8.GetString(decodedData);
Console.WriteLine($"Decoded: {decodedText}");