// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Давай найдем максимальное число!");
Console.WriteLine("Введите три числа");
string input_1 = Console.ReadLine();
int number_1 = Convert.ToInt32(input_1);
string input_2 = Console.ReadLine();
int number_2 = Convert.ToInt32(input_2);
string input_3 = Console.ReadLine();
int number_3 = Convert.ToInt32(input_3);
if (number_1>number_2)
    {
        if (number_1>number_3)
        {
            Console.WriteLine("Максимальное число " + number_1);
        }
        else
            Console.WriteLine("Максимальное число " + number_3);
    }
else if (number_2>number_3)
    {
        Console.WriteLine("Максимальное число " + number_2);
    }
else 
    Console.WriteLine("Максимальное число " + number_3);
    
   