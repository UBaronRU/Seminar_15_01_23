int Num1; // Первое число
int Num2_1 = 7; //  Первое кратное число
int Num2_2 = 23; //  Второе кратное число
int Num3; // Кратность 1
int Num4; // Кратность 2
int Num5; // Остаток

Console.Write("Введите основное число  : ");
Num1 = int.Parse(Console.ReadLine());

if (Num1 > 0 & Num2_1 > 0 & Num2_2 > 0)
{
if (Num1%Num2_1 == 0 & Num1%Num2_2 == 0) 
{
    Console.WriteLine("Число "+ Num1 +" кратно " + Num2_1 +" и "+Num2_2+ "(делится без остатка)");
}
else 
{
    
    Console.WriteLine("Число "+ Num1 +" не кратно " + Num2_1 +" и " + Num2_2);
}
}
else
{
  Console.WriteLine("Ошибка! Числа должны быть больше 0");  
}
/// Решаем через 



﻿//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int Num1; // Координата х
int Num2; //  Координата y
Console.Write("Введите Координата х  : ");
Num1 = int.Parse(Console.ReadLine());
Console.Write("Введите Координата y: ");
Num2 = int.Parse(Console.ReadLine());
if (Num1 > 0 && Num2 > 0) Console.WriteLine ("1 четверть");
if (Num1 > 0 && Num2 < 0) Console.WriteLine ("2 четверть");
if (Num1 < 0 && Num2 > 0) Console.WriteLine ("4 четверть");
if (Num1 < 0 && Num2 < 0) Console.WriteLine ("3 четверть");
// Второй способ
if (Num1 > 0 ) 
{
    if (Num2 > 0 ) 
    {
        Console.WriteLine ("1 четверть");
    }
    else
    {
        Console.WriteLine ("2 четверть");
    }
}
else
{
 if (Num2 > 0 ) 
    {
        Console.WriteLine ("4 четверть");
    }
    else
    {
        Console.WriteLine ("3 четверть");
    }
}
