string output;
int number;

Console.WriteLine("=== Is Your Number Positive, Negative, or Zero ===");
Console.WriteLine();

Console.Write("Enter number: ");
number = int.Parse(Console.ReadLine());

if (number > 0)
{
	output = "positive";
}
else if (number < 0)
{
	output = "negative";
}
else
{
	output = "zero";
}

Console.WriteLine();
Console.WriteLine($"The number is {output}");