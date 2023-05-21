// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Четное или не четное??");
Console.WriteLine ("Введите число:");
string input_1 = Console.ReadLine();
int number_1 = Convert.ToInt32(input_1);
int number = number_1;
number_1 %= 2;
if (number_1 ==0)
    {
        Console.WriteLine("Число "+ number + " четное");
    }
else 
    Console.WriteLine("Число " + number + " не четное");