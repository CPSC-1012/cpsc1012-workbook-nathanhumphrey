// Prompting for input

// Method call
string firstName = Prompt("Enter first name: ");
string lastName = Prompt("Enter last name: ");

int age = PromptForInt("Enter your age: ", "Enter valid age.");

Console.WriteLine($"Hello, {firstName} {lastName}.");
Console.WriteLine($"Looks like you're {age} years old.");

// Method definition

/// <summary>
/// Prompt the user for input
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