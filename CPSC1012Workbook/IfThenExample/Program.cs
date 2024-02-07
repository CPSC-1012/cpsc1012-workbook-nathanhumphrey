// Prompt the user for a number and thank them for entering it.
// Also, inform the user if their number is even.

int number;

Console.WriteLine("==== Is Your Number Even? ===");
Console.WriteLine();

Console.Write("Please enter a number: ");
number = int.Parse(Console.ReadLine());

// if-then single alternative branch
if (number % 2 == 0)
{
	Console.WriteLine("Your number is even!");
}

Console.WriteLine();
Console.WriteLine("Thanks for entering a number.");