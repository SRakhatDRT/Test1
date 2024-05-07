/*
Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n.

m = 2, n = 3 -> A(n,m) = 29
*/

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int n, int m)
{
    if (n == 0) 
    {
        return m + 1;
    }
    else if (m == 0) 
        {
            return akkerman(n - 1, 1);
        }
        else return akkerman(n - 1, akkerman(n, m - 1));
}

Console.Write($"Функция Аккермана = {akkerman(n, m)} ");

