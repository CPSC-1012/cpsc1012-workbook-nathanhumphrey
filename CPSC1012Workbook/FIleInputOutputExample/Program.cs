string filename = "hello-world.txt";
StreamWriter writer = null;
StreamReader reader = null;

// Simple write to a file
try
{
	// Open the writer
	writer = new StreamWriter(filename);

	// Write to the file
	writer.WriteLine("Hello world into a file!");
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


// Simple read from a file
try
{
	// Open the reader
	reader = new StreamReader(filename);
	string line;

	// Need to check for content!
	if (!reader.EndOfStream)
	{
		line = reader.ReadLine();
		Console.WriteLine($"The line is: {line}");
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