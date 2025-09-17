// As it was not specified, there is no error handling in this program and it
// will simply crash if the input is not representable by a float.

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int product = num1 * num2;

Console.WriteLine("Product of numbers: " + product);

