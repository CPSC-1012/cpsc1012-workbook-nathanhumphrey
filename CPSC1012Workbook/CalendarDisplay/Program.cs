string firstDay;
int days;
// Initialize an array for validation, lookup, and output
string[] dayNames = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

// Validate the first day
do
{
	firstDay = Prompt("Enter the first day of the month (e.g. Mon, Tue, etc.): ");
} while (!IsValidDayName(firstDay, dayNames));

// Validate the number of days - between 28 and 31 inclusive
do
{
	days = PromptForInt("Enter the number of days in the month: ");
} while (days < 28 ||  days > 31);

// Determine how many blank days to include, if any
int dayCount = IndexOfDayName(firstDay, dayNames);

// Display day names
for (int i = 0; i < dayNames.Length; i += 1)
{
	Console.Write($"{dayNames[i]} ");
}

// Go to the next line
Console.WriteLine();

// Display the blank days
for (int i = 0; i < dayCount; i += 1)
{
	Console.Write("    ");
}

// Display the day numbers
for (int i = 1; i <= days; i += 1)
{
	// Use ternary operator
	Console.Write($" {(i < 10 ? $"0{i}" : i)} ");

	if ((i + dayCount) % 7 == 0)
	{
		Console.WriteLine();
	}
}

/// <summary>
/// Find the index of the name in the array
/// </summary>
/// <param name="name">The name to search for</param>
/// <param name="names">The array of names to search in</param>
/// <returns>The index of the found name or -1 if not found</returns>
static int IndexOfDayName(string name, string[] names)
{
	name = name.ToLower();
	int dayIndex = -1;

	for (int i = 0; i < names.Length; i += 1)
	{
		if (names[i].ToLower() == name)
		{
			dayIndex = i;
			i = names.Length;
		}
	}

	return dayIndex;
}

/// <summary>
/// Determine if the name is in the array
/// </summary>
/// <param name="name">The name to search for</param>
/// <param name="names">The array of names to search in</param>
/// <returns>True if found, false if not found</returns>
static bool IsValidDayName(string name, string[] names)
{
	name = name.ToLower();
	bool isValid = false;

	for (int i = 0; i < names.Length; i += 1)
	{
		if (names[i].ToLower() == name)
		{
			isValid = true;
			i = names.Length;
		}
	}

	return isValid;
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