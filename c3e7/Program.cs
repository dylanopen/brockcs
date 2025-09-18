const double BORDER = 0.5;
const double COST_PER_SQUARE_METRE = 0.75;

Console.Write("Width (m) = ");
double width = Convert.ToDouble(Console.ReadLine());
Console.Write("Height (m) = ");
double height = Convert.ToDouble(Console.ReadLine());

width -= BORDER*2;
height -= BORDER*2;

double cost = width * height * COST_PER_SQUARE_METRE;

Console.WriteLine($"Cost: {cost:N2}");

