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



