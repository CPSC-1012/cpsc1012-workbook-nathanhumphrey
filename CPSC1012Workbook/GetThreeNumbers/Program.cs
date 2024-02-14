int number;
int count = 0;
const int MaxEntries = 3;

Console.WriteLine("==== Get Three Numbers ====");
Console.WriteLine();

while (count < MaxEntries)
{
	Console.Write($"Enter number {count + 1}: ");
	number = int.Parse(Console.ReadLine());
	Console.WriteLine($"Your number is {number}");

	// Increment the count
	count = count + 1;
	
	// Alternative increment methods
	// count += 1; 
	// count++;
}

Console.WriteLine();
Console.WriteLine("Program End");