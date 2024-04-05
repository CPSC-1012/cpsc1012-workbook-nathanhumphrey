string filename = "test.txt";
StreamWriter writer = null;

try
{
	writer = new StreamWriter(filename);

	writer.WriteLine("Hello world in a file!");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	if (writer != null)
	{
		writer.Close();
	}
}

try
{
	StreamReader reader = new StreamReader(filename);

	string line = string.Join("**", reader.ReadLine().Split(" "));

	reader.Close();

	Console.WriteLine($"The line read is: {line}");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}