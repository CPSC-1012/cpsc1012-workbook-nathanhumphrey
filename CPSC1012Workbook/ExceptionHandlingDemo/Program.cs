int number;

Console.WriteLine("PROGRAM START");
Console.WriteLine();

try
{
	Console.Write("Enter a number: ");
	number = int.Parse(Console.ReadLine());
}
catch(Exception e)
{
	Console.WriteLine("Something bad happened");
	Console.WriteLine(e.Message);
}

Console.WriteLine();
Console.WriteLine("PROGRAM END");