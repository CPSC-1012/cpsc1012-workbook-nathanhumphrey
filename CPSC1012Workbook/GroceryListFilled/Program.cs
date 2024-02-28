// Create an array of type string, that can hold
// five strings.
const int GroceryItemsLength = 3;
string[] groceryItems = new string[GroceryItemsLength];

Console.WriteLine("==== Grocery List Maker ====");
Console.WriteLine();

// For loop solution to load the array
for (int index = 0; index < GroceryItemsLength;  index += 1)
{
	Console.Write($"Enter item {index + 1}: ");
	groceryItems[index] = Console.ReadLine();
}

// Print the list
Console.WriteLine();
Console.WriteLine("##### GROCERY ITEMS #####");
Console.WriteLine();
for (int index = 0; index < GroceryItemsLength; index += 1)
{
	Console.WriteLine($"Item {index + 1} {groceryItems[index]}");
}

Console.WriteLine();
Console.WriteLine("####  END OF ITEMS  #####");

/*
// While loop solution
int index = 0;

while (index < 5)
{
	// Crude method of filling the array
	Console.Write($"Enter item {index + 1}: ");
	groceryItems[index] = Console.ReadLine();

	index += 1;
}
*/

/*
// Crude method of filling the array
Console.Write("Enter item 1: ");
groceryItems[0] = Console.ReadLine();

Console.Write("Enter item 2: ");
groceryItems[1] = Console.ReadLine();

Console.Write("Enter item 3: ");
groceryItems[2] = Console.ReadLine();

Console.Write("Enter item 4: ");
groceryItems[3] = Console.ReadLine();

Console.Write("Enter item 5: ");
groceryItems[4] = Console.ReadLine();
*/