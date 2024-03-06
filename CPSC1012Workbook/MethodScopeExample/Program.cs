int num1 = 2;
int num2 = 3;
int a = 5;
int b = 10;

Console.WriteLine(AddTwoNumbers(num2, num1));
Console.WriteLine(AddTwoNumbers(a, b));
Console.WriteLine(AddTwoNumbers(9, 9));

static int AddTwoNumbers(int num1, int num2)
{
	int sum = num1 + num2;

	return sum;
}