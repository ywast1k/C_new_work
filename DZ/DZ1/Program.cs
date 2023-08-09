Console.Clear();
Console.WriteLine("Здравствуйте! Введите значение 1:  ");

int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2:  ");

int number2 = Convert.ToInt32(Console.ReadLine());
if(number1>number2)
 {
     Console.Write("Max= ");
      Console.Write(number1);
 }
 else
 {
    Console.Write("Max= ");
     Console.Write(number2);
 }
