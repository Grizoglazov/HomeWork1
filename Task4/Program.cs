// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");         // запуск программы
string n = Console.ReadLine();              // условие задачи (ввод данных от пользователя и создание переменной)
int max = Convert.ToInt32(n);               // присвоение переменной типа данных целое значение
int min = 1;                                // условие задачи
int count = 0;
int result = 0;
while (count < max)
{
        int balance = min %=2;
        result ++;
        if (balance == 0)
        {
            Console.Write(result + " ,");
            min ++;           
        }
        else
        min ++;  
    count ++;
}
Console.WriteLine("End");