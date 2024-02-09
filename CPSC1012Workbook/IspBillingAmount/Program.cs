char package;
int hours;
double billingAmount;

Console.WriteLine("==== ISP Billing Calculator ====");
Console.WriteLine();

Console.WriteLine("---- Menu of Packages ----");
Console.WriteLine("[A] Basic Package");
Console.WriteLine("[B] Intermediate Package");
Console.WriteLine("[C] Unlimited Package");
Console.WriteLine("");

Console.Write("Enter customer package: ");
package = Console.ReadLine().ToUpper()[0]; // always uppercase

switch(package)
{
	case 'A':
		// Carry out the basic package billing calculations
		Console.WriteLine("Package A selected");
		break;
	case 'B':
		// Carry out the intermediate package billing calculations
		Console.WriteLine("Package B selected");
		break;
	case 'C':
		// Carry out the unlimited package billing calculations
		Console.WriteLine("Package C selected");
		break;
	default:
		Console.WriteLine($"Sorry, package {package} does not exist.");
		break;
}

// Equivalent if-else for the above switch statement
//if (package == 'A')
//{

//}
//else if (package == 'B')
//{

//}
//else if (package == 'C')
//{
    
//}
//else
//{

//}

Console.WriteLine();

// TODO: display the bill amount - but only if one was calculated

Console.WriteLine("End Program");