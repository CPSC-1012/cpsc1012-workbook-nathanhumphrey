// Demonstrates various String properties and methods
string value = "Hello, Nathan.";

// Get the total number of chars in the string
int length = value.Length;
Console.WriteLine($"The length of the string: {length}");

// Access a single char
char firstChar = value[0];
Console.WriteLine($"The first character: {firstChar}");
char lastChar = value[length - 1];
Console.WriteLine($"The last character: {lastChar}");

// Upper and Lower
Console.WriteLine($"The string UPPER: {value.ToUpper()}");
Console.WriteLine($"The string lower: {value.ToLower()}");

// Get a substring
string hello = value.Substring(0, 5);
Console.WriteLine($"Hello: {hello}");

// Search for a char or a substring
int commaPosition = value.IndexOf(',');
Console.WriteLine($"The comma is at pos: {commaPosition}");
int namePostion = value.IndexOf("Nathan");
Console.WriteLine($"The name is at pos: {namePostion}");

// Does a string contain another string
bool containsName = value.Contains("Nathan");
bool containsZ = value.Contains('z');
Console.WriteLine($"Contains name: {containsName}");
Console.WriteLine($"Contains z: {containsZ}");

// TASK: using the methods and properties above, create a variable
// that contains your name from the original string value
int firstLetterPos = value.IndexOf(' ') + 1;
int periodPos = value.IndexOf('.');
int nameLength = periodPos - firstLetterPos;

Console.WriteLine($"The name is: {value.Substring(firstLetterPos, nameLength)}");