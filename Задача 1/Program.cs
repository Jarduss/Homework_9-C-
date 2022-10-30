/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

void getNumbers(int N)
{
    if (N == 1) 
    {
        System.Console.WriteLine(N);
        return;
    }
    else 
    {
    System.Console.WriteLine(N); 
    getNumbers(N-1);  
    }
}
getNumbers(N);