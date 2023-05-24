// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Давайте сравним числа!!");
Console.WriteLine ("Введите первое число:");
string input_1 = Console.ReadLine();
int number_1 = Convert.ToInt32(input_1);
Console.WriteLine ("Введите второе число:");
string input_2 = Console.ReadLine();
int number_2 = Convert.ToInt32(input_2);
if (number_1 > number_2)
    {
        Console.WriteLine("Число "+ number_1 + " больше чем " + number_2);
    }
else 
    Console.WriteLine("Число " + number_2 + " больше чем " + number_1);