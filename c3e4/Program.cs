Console.WriteLine("Enter 5 examination marks:");
double total = 0.0;
for (int i = 0; i < 5; i++) {
    total += Convert.ToInt32(Console.ReadLine());
}
double mean = total / 5.0;
Console.WriteLine("Total: " + total);
Console.WriteLine("Mean: " + mean);
