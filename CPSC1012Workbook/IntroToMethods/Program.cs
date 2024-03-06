// Prompting for input

// Method call
string firstName = Prompt("Enter first name: ");
string lastName = Prompt("Enter last name: ");

int age = PromptForInt("Enter your age: ", "Enter valid age.");

Console.WriteLine($"Hello, {firstName} {lastName}.");
Console.WriteLine($"Looks like you're {age} years old.");

// Method definition
static string Prompt(string label)
{
	Console.Write(label);
	return Console.ReadLine();
}

// Method reuse and Exception handling in a method
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