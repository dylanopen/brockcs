Console.Write("Gross Price: £");
double gross = Convert.ToDouble(Console.ReadLine());
Console.Write("Discount rate (%): ");
double discountPercentage = Convert.ToDouble(Console.ReadLine()) * 0.01;

double discount = gross * discountPercentage;
double finalPrice = gross - discount;

Console.WriteLine($"Discount: {discount:C}");
Console.WriteLine($"Discount price: {finalPrice:C}");

