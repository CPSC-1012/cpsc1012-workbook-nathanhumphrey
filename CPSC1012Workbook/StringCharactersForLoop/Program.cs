string userInput;
//int index = 0; // 1

Console.WriteLine("==== String Characters ====");
Console.WriteLine();

Console.Write("Eneter a phrase: ");
userInput = Console.ReadLine();

// FOR LOOP EXAMPLE
for (int index = 0; index < userInput.Length; index += 1)
{
	Console.WriteLine(userInput[index]);
}

// WHILE LOOP EXAMPLE
//while (index < userInput.Length) // 2
//{
//    Console.WriteLine(userInput[index]);

//    index = index + 1; // 3
//    //index += 1;
//    //index++;
//}

Console.WriteLine();
Console.WriteLine("END PROGRAM");