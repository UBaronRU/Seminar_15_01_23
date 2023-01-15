//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
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