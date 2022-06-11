using LogicalProgramming;

Console.WriteLine("Enter a Number for Logical Programming Problem.\n");
Console.WriteLine("1 for Fibonacci Series");
Console.WriteLine("2 for Perfect Number");

int Problem = Convert.ToInt32(Console.ReadLine());

switch (Problem)
{
    case 1:
        FibonacciSeries fibonacciSeries = new FibonacciSeries();
        fibonacciSeries.Series();
        break;
    case 2:
        PerfectNumber perfectNumber = new PerfectNumber();
        perfectNumber.Perfect();
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}