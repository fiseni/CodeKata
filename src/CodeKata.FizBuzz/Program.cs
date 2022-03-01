
using CodeKata.FizBuzz;

var fizzBuzzService = new FizzBuzzServie();

for (int i = 1; i <= 16; i++)
{
    Console.WriteLine(fizzBuzzService.FormatNumber(i));
}

Console.ReadLine();