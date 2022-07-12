// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Akk(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akk(m - 1, 1);
    if (m > 0 && n > 0) return Akk(m - 1, Akk(m, n - 1));
    return Akk(m, n);
}