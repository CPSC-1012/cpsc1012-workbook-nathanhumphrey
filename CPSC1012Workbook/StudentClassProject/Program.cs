using System;

const int MaxStudents = 32;
Student[] students = new Student[MaxStudents];

int studentCount = 0;
string filename;
string option;

Console.WriteLine("==== Student Records Manager ====");
Console.WriteLine();

do
{
	DisplayMenu();
	option = Prompt("Enter menu option: ").ToUpper();

	switch (option)
	{
		case "E":
			// Enter student data
			studentCount = EnterStudents(students);
			break;
		case "S":
			// Save student data
			// TODO: validate that the entered name is not empty
			filename = Prompt("Enter name of file to save to: ");
			SaveStudentData(filename, students, studentCount);
			break;
		case "Q":
			Console.WriteLine();
			Console.WriteLine("Goodbye");
			break;
		default:
			Console.WriteLine($"Sorry, {option} is not a valid option.");
			break;
	}

} while (option != "Q");

// ###########################################################################
//								METHOD DECLARATIONS
// ###########################################################################

/// <summary>Display the main menu</summary>
static void DisplayMenu()
{
	Console.WriteLine();
	Console.WriteLine("     Menu Options     ");
	Console.WriteLine("======================");
	Console.WriteLine("[E]nter student data");
	Console.WriteLine("[S]ave student data");
	Console.WriteLine("[Q]uit program");
	Console.WriteLine();
}

/// <summary>
/// Writes student data to a file.
/// <param name="filename">The filename to write the data to</param>
/// <param name="students">The array to hold students</param>
/// <param name="count">The count of students in the arrays</param>
/// </summary>
static void SaveStudentData(string filename, Student[] students, int count)
{
	StreamWriter writer = null;

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
			writer.WriteLine(students[index].ToCsvString());
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
}

/// <summary>
/// Allow the user to enter student data.
/// <param name="students">The array to hold the students</param>
/// <returns>The studentCount of the entered students</returns>
/// </summary>
static int EnterStudents(Student[] students)
{
	int size = students.Length;
	string response = "Y";
	int count = 0;

	do
	{
		// NOTE: the following try/catch is not best practice, but is used here
		// for brevity.
		try
		{
			Student tempStudent = new Student();

			tempStudent.FirstName = Prompt($"Enter first name {count + 1}: ");
			tempStudent.LastName = Prompt($"Enter last name {count + 1}: ");
			tempStudent.StudentId = PromptForInt($"Enter id {count + 1}: ");

			// Place the student object into the array
			students[count] = tempStudent;

			count += 1;

			Console.WriteLine();
			Console.Write("Do you want to enter another student (y/N)? ");
			response = Console.ReadLine().ToUpper();
		}
		catch (Exception ex )
		{
			Console.WriteLine($"There was an error: {ex.Message}");
		}

	} while (count < size && response == "Y");

	return count;
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