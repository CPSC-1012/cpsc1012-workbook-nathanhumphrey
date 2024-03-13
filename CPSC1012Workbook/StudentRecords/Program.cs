using System;

const int MaxStudents = 25;
string[] firstNames = new string[MaxStudents];
string[] lastNames = new string[MaxStudents];
int[] studentsIds = new int[MaxStudents];
string response = "Y";
StreamWriter writer = null;
string filename = "students.csv";

Console.WriteLine("==== Student Records Writer ====");
Console.WriteLine();

int count = 0;

do
{
	firstNames[count] = Prompt($"Enter first name {count + 1}: ");

	lastNames[count] = Prompt($"Enter last name {count + 1}: ");

	studentsIds[count] = PromptForInt($"Enter id {count + 1}: ");
	
	count += 1;

	Console.WriteLine();
	Console.Write("Do you want to enter another student (y/N)? ");
	response = Console.ReadLine().ToUpper();

} while (count < MaxStudents && response == "Y");

// Write the students to a file
try
{
	// Open the writer
	writer = new StreamWriter(filename);

	// Write the header record
	writer.WriteLine("First Name,Last Name,Student ID");

	// Write the students to the file
	for (int index = 0; index < count; index += 1)
	{
		writer.WriteLine($"{firstNames[index]},{lastNames[index]},{studentsIds[index]}");
	}
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	if (writer != null)
	{
		// Close the writer
		writer.Close();
	}
}

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