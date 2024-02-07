// Develop a program that prompts the user to guess a randomly generated
// number between 1 and // Develop a program that prompts the user to
// guess a randomly generated number between 1 and 10.
// The program should allow the user a maximum of three attempts to guess
// the correct number. If the user guesses correctly within the given attempts,
// the program should display a congratulatory message; otherwise, it should
// reveal the correct number.

int random = Random.Shared.Next(1, 11); // 1 through 10
int userGuess;

// Debug option
Console.WriteLine($"The random number is: {random}");

Console.WriteLine("=== Number Guessing Game ===");
Console.WriteLine();

Console.WriteLine("You get three guesses to guess the number.");
Console.WriteLine();

Console.Write("Enter guess #1: ");
userGuess = int.Parse(Console.ReadLine());

if (userGuess == random)
{
	Console.WriteLine("You win! It took 1 guess.");
}
else
{
	Console.Write("Enter guess #2: ");
	userGuess = int.Parse(Console.ReadLine());

	if (userGuess == random)
	{
		Console.WriteLine("You win! It took 2 guesses.");
	}
	else
	{
		Console.Write("Enter guess #3: ");
		userGuess = int.Parse(Console.ReadLine());

		if (userGuess == random)
		{
			Console.WriteLine("You win! It took 3 guesses.");
		}
		else
		{
			Console.WriteLine($"Sorry, you lose. The number is {random}");
		}
	}
}

Console.WriteLine();
Console.WriteLine("Thanks for playing.");