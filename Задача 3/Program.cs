/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

System.Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine());
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

int Akkerman = Formula(M, N);

Console.Write($"Результат вычисления функции Аккермана = {Akkerman} ");

int Formula(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Formula(M - 1, 1);
  else return Formula(M - 1, Formula(M, N - 1));
}

