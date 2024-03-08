// Create a program that will allow the user to enter up to 25 numbers into an
// array.Calculate and display the mean average of the numbers.

const int MaxNumbers = 25;
int[] numbers = new int[MaxNumbers];
int numbersCount = 0;
int mean;

numbersCount = GetUserNumbers(numbers);
mean = MeanAverageOfNumbers(numbers, numbersCount);

Console.WriteLine();
Console.WriteLine($"The mean of the numbers is: {mean}");

// TODO: add method comment
static int GetUserNumbers(int[] numbers)
{
	int count = 0;
	string response = "n";

	// Load numbers into the array
	do
	{
		numbers[count] = PromptForInt($"Enter number {count + 1}: ");
		count += 1;

		response = Prompt("Enter another number N/y: ").ToLower();

	} while (count < numbers.Length && response == "y");

	return count;
}

// TODO: add method comment
static int MeanAverageOfNumbers(int[] numbers, int count)
{
	int sum = 0;

	// Calculate the mean average
	for (int i = 0; i < count; i += 1)
	{
		// sum = sum + numbers[i];
		sum += numbers[i];
	}

	return sum / count;
}

/// </summary>
/// <param name="label">The prompt label to display</param>
/// <returns>The input the user entered as a string</returns>
static string Prompt(string label)
{
	Console.Write(label);
	return Console.ReadLine();
}

// Method reuse and Exception handling in a method

/// <summary>Prompt the user for input as an integer</summary>
/// <param name="label">The prompt label to display</param>
/// <param name="errorMessage">A custom error message to display if input is invalid (optional)</param>
/// <returns>The input the user entered as an int</returns>
static int PromptForInt(string label, string errorMessage = "Sorry, enter a valid integer.")
{
	int intInput = 0;
	bool isValidInt = false;

	do
	{
		string stringInput = Prompt(label);

		try
		{
			intInput = int.Parse(stringInput);
			isValidInt = true;
		}
		catch
		{
			Console.WriteLine(errorMessage);
		}
	} while (!isValidInt);

	return intInput;
}