Console.Write("Height (cm) = ");
double cms = Convert.ToDouble(Console.ReadLine());
Console.Write("Weight (kg) = ");
double kgs = Convert.ToDouble(Console.ReadLine());

double ins = cms * 2.54;
double lbs = kgs / 2.2;

Console.WriteLine($"Height (ins) = {ins:N2}");
Console.WriteLine($"Weight (lbs) = {lbs:N2}");

