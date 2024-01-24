double totalUnitSales;
double totalCompanySales;
double unitSalesPercent;

Console.WriteLine("Unit Sales Contribution Calculator");
Console.WriteLine();

Console.Write("Enter total company sales: ");
totalCompanySales = double.Parse(Console.ReadLine());

Console.Write("Enter unit sales percent: ");
unitSalesPercent = double.Parse(Console.ReadLine());

totalUnitSales = totalCompanySales * unitSalesPercent;

Console.WriteLine();
Console.WriteLine($"The unit sales are {totalUnitSales:C}.");
Console.WriteLine("Program End");