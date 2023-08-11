Console.WriteLine("Введение значение");
int number = int.Parse(Console.ReadLine());
int start = -number;
while(start<=number)
{
    Console.Write(start);
    if(start!=number)
    {
        Console.Write(", ");
    }
    start++;
}
