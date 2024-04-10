// Demonstrate the differences between arrays and lists

// Create an array
int[] numbersArray = new int[3];

// Create a list
List<int> numbersList = new List<int>();

// Assign values to the array
numbersArray[0] = 1;
numbersArray[1] = 2;
numbersArray[2] = 3;

// Assign values to the list
numbersList.Add(4);
numbersList.Add(5);
numbersList.Add(6);

// Display the elements in the array
for (int i = 0; i < numbersArray.Length; i += 1)
{
	Console.WriteLine($"Array number {i + 1}: {numbersArray[i]}");
}

// Display the elements in the list
for (int i = 0; i < numbersList.Count; i += 1)
{
	Console.WriteLine($"List number {i + 1}: {numbersList[i]}");
}

// Using foreach statement
foreach (int num in numbersList)
{
	Console.WriteLine($"List number {num}");
}