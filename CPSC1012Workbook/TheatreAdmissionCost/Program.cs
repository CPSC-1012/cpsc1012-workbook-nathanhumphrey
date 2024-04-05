double admission;
int age;

Console.WriteLine("=== Theatre Admission ===");
Console.WriteLine();

// Display the ticket prices
Console.WriteLine("Children 6 and under = FREE ($0.00)");
Console.WriteLine("Students 7 to 17 = $9.80");
Console.WriteLine("Adults 18 to 54 = $11.35");
Console.WriteLine("Seniors 55+ = $10.00");

Console.WriteLine();

Console.Write("Enter age: ");
age = int.Parse(Console.ReadLine());

// Test plan: 6, 7, 17, 18, 54, 55

if (age <= 6)
{
	admission = 0;
}
else if (age <= 17)
{
	admission = 9.8;
}
else if (age <= 54)
{
	admission = 11.35;
}
else
{
	admission = 10;
}

Console.WriteLine();
Console.WriteLine($"The admission cost is {admission:C}");