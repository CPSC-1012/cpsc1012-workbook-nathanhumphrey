const int MaxBudgetItems = 25;
string[] labels = new string[MaxBudgetItems];
double[] amounts = new double[MaxBudgetItems];
string response = "Y";

Console.WriteLine("==== Budget Maker ====");
Console.WriteLine();

int count = 0;

do
{
	Console.Write($"Enter label {count + 1}: ");
	labels[count] = Console.ReadLine();

	// TODO: exception handling!
	Console.Write($"Enter amount for {labels[count]}: ");
	amounts[count] = double.Parse(Console.ReadLine());

	count += 1;

	Console.WriteLine();
	Console.Write("Do you want to enter another item (y/N)? ");
	response = Console.ReadLine().ToUpper();

} while (count < MaxBudgetItems && response == "Y");

// Use the 'count' as it accurately tracks the actual
// number of budget items

Console.WriteLine();
Console.WriteLine("---- MONTHLY BUDGET ----");
for (int index = 0; index < count; index += 1)
{
	Console.WriteLine($"{labels[index],-11}    {amounts[index],9:C}");
}