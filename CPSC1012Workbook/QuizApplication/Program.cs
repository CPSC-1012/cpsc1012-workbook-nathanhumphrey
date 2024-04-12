// Invalid tests
try
{
	Quiz temp = new Quiz(0, 0);
}
catch (Exception ex)
{
	Console.WriteLine($"\"Total must be positive\" should match {ex.Message}");
}

// Valid tests

Quiz q = new Quiz(10, 10);
q.StudentName = "Jane Doe";
q.Mark = 5;

Console.WriteLine($"{q.StudentName} has percentage {q.Percentage} should match 50");