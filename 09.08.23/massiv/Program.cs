﻿Console.WriteLine("Введите номер недели");
int day = int.Parse(Console.ReadLine());
string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница" , "Суббота", "Воскресенье"};
Console.WriteLine(days[day-1]);
