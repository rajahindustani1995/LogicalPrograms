using LogicalProgramming;

Console.WriteLine("Enter a Number for Logical Programming Problem.\n");
Console.WriteLine("1 for Flip Coin and Print Percentage of Heads and Tails");


int Problem = Convert.ToInt32(Console.ReadLine());

switch (Problem)
{
    case 1:
        FibonacciSeries fibonacciSeries = new FibonacciSeries();
        fibonacciSeries.Series();
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}