// Prompt the user for a number and thank them for entering it.
// Also, inform the user if their number is even or if it is odd.

int number;

Console.WriteLine("==== Is Your Number Even or Odd? ===");
Console.WriteLine();

Console.Write("Please enter a number: ");
number = int.Parse(Console.ReadLine());

// if-else dual alternative branch
if (number % 2 == 0)
{
	Console.WriteLine("Your number is even!");
}
else
{
	Console.WriteLine("Your number is odd!");
}

Console.WriteLine();
Console.WriteLine("Thanks for entering a number.");