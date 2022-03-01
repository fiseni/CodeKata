
using CodeKata.FizzBuzz;

var fizzBuzzService = new FizzBuzz();

for (int i = 1; i <= 16; i++)
{
    Console.WriteLine(fizzBuzzService.FormatNumber(i));
}

Console.ReadLine();