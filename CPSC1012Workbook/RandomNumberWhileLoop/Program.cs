const int MaxGuesses = 3;
int random = Random.Shared.Next(1, 11); // 1 through 10
int userGuess = 0;
int count = 0;

// Debug option
Console.WriteLine($"The random number is: {random}");

Console.WriteLine("=== Number Guessing Game ===");
Console.WriteLine();

Console.WriteLine($"You get {MaxGuesses} guesses to guess the number.");
Console.WriteLine();

// Pre-Condition Solution
//while (userGuess != random && count < MaxGuesses)
//{
//	Console.Write($"Enter guess #{count + 1}: ");
//	userGuess = int.Parse(Console.ReadLine());

//	count += 1;
//}

// Post-Condition Solution
do
{
	Console.Write($"Enter guess #{count + 1}: ");
	userGuess = int.Parse(Console.ReadLine());

	count += 1;
} while (userGuess != random && count < MaxGuesses);

Console.WriteLine();

if (userGuess == random)
{
	Console.WriteLine($"You won! It took {count} guesses.");
}
else
{
	Console.WriteLine("Sorry, you lost :(");
}