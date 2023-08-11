Console.Clear();
Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int start = 1;
while(start<=number)
{
    Console.Write(start + " ");
    start++;
}

