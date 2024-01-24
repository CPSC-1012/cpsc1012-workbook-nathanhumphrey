// Capture input from the user
// Task - Display a greeting to a user including their name and age.

int userAge;
string userName;

Console.Write("Please enter your name: ");
userName = Console.ReadLine();

Console.Write("Please enter your age: ");
// Must parse to convert from string to int type
userAge = int.Parse(Console.ReadLine());

Console.WriteLine();
// Concatenation
Console.WriteLine("Hello " + userName + " you are " + userAge + " years old.");
// Interpolation
Console.WriteLine($"Hello {userName} you are {userAge} years old.");