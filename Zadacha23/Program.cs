//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Number(int xc)
{
    int c = 1;
    while (xc != c - 1)
    {
        double y = Math.Pow(c,3);
        Console.Write($"{c} ");
        Console.WriteLine(y);
        c += 1;
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0) Number(x);
else Console.WriteLine("Вы ввели не N число!");