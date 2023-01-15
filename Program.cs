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
﻿int Num1 = 0;
Console.Write("Введите число от 10000 до 99999, а мы покажем вторую цифру : ");
Num1 = int.Parse(Console.ReadLine());
int Num1_1 = 0;
int Num1_2 = 0;
int Num1_3 = 0;
int Num1_4 = 0;
int Num1_5 = 0;
Num1_5 = (Num1%10);
Num1_4 = (Num1/10)%10;
Num1_3 = (Num1/100)%10;
Num1_2 = (Num1/1000)%10;
Num1_1 = (Num1/10000);
Console.Write(Num1_1);
Console.Write(" ");
Console.Write(Num1_2);
Console.Write(" ");
Console.Write(Num1_3);
Console.Write(" ");
Console.Write(Num1_4);
Console.Write(" ");
Console.Write(Num1_5);
//
//Console.Write("Ведите число: ");
//int number = int.Parse(Console.ReadLine());
//int mod = 0;
//int newmod = 0;
//int i=0;
//for(i= number;number!=0;number=number/10)
//{
//   mod = number % 10;
//    newmod = newmod*10 + mod;
//}
//if(i == newmod) Console.WriteLine("Число палиндром");
//else Console.WriteLine("число не является палиндромом");
