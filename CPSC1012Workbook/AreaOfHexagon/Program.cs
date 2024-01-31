//
// Purpose: To calculate the area of a hexagon
// Author: Nathan Humphrey
// Date Modified: Jan 30, 2024
//
double area;
double side;

Console.WriteLine("=== Hexagon Area Calculator ===");
Console.WriteLine();

Console.Write("Enter the length of the side: ");
side = double.Parse(Console.ReadLine());

// Calculate the area in chunks
double top = 3 * Math.Sqrt(3);
double main = top / 2;
double sSquared = Math.Pow(side, 2); // side * side

area = main * sSquared;

// Calculate all in one line
area = ((3 * Math.Sqrt(3)) / 2) * (Math.Pow(side, 2));

Console.WriteLine();
Console.WriteLine($"The area of the hexagon is {area:0.0000}");
Console.WriteLine();
Console.WriteLine("End Program");