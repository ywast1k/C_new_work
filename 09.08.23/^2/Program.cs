Console.WriteLine("Введите число: ");
// string num = Console.ReadLine()!; // "4565"
// int number = int.Parse(num); 
int number = int.Parse(Console.ReadLine()!);

int square = number * number;
Console.WriteLine("Квадрат числа "+ number + " равен " + square);
Console.WriteLine($"Квадрат числа {number} равен {square}");
