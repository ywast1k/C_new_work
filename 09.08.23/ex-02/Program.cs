Console.WriteLine("Введите число 1: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if(number2*number2 == number)
{
    Console.WriteLine($"число {number} является квадратом {number2}"); 
}
else
{
    Console.WriteLine($"число {number} НЕ является квадратом {number2}"); 
}
