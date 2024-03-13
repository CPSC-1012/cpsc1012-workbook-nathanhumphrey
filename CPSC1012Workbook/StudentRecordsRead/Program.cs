const int MaxStudents = 25;
string[] firstNames = new string[MaxStudents];
string[] lastNames = new string[MaxStudents];
int[] studentsIds = new int[MaxStudents];
string response = "Y";
StreamReader reader = null;
string filename = "students.csv";

Console.WriteLine("==== Student Records Reader ====");
Console.WriteLine();

int count = 0;

try
{
	// Open the reader
	reader = new StreamReader(filename);
	string line;

	// Priming read, skip the header record
	reader.ReadLine();

	// Need to check for content!
	while (!reader.EndOfStream)
	{
		line = reader.ReadLine(); // "Jane,Doe,123456"
		string[] fields = line.Split(','); // ["Jane","Doe","123456"]

		firstNames[count] = fields[0]; // first name
		lastNames[count] = fields[1]; // last name
		studentsIds[count] = int.Parse(fields[2]); // parse the int id

		// We read in a student, increase the count
		count += 1;
	}
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	if (reader != null)
	{
		// Close the reader
		reader.Close();
	}
}


Console.WriteLine();
Console.WriteLine("First Name    Last Name    Student Id");
Console.WriteLine("=====================================");

// Display the students in the array
for (int index = 0; index < count; index += 1)
{
	// TODO: properly align the output
	Console.WriteLine($"{firstNames[index]}   {lastNames[index]}   {studentsIds[index]}");
}