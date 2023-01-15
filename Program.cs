int Num1 = 0;
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
