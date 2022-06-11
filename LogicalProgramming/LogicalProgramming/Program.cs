using LogicalProgramming;

Console.WriteLine("Enter a Number for Logical Programming Problem.\n");
Console.WriteLine("1 for Fibonacci Series");
Console.WriteLine("2 for Perfect Number");
Console.WriteLine("3 for Prime Number");
Console.WriteLine("4 for Reverse Number");

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
    case 3:
        PrimeNumber primeNumber = new PrimeNumber();
        primeNumber.Prime();
        break;
    case 4:
        ReverseNumber reverseNumber = new ReverseNumber();  
        reverseNumber.Reverse();
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}