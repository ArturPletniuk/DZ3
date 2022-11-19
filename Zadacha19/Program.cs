//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
//палиндромом.Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
int Funk(int xc)
{
    if (xc >= 10000 && xc <= 99999)
    {
        int c = xc / 10;
        c = xc % 10;
        int y = xc / 10000;
        if (c == y)
        {
            c = xc / 1000;
            c = c % 10; 
            y = xc % 100;
            y = y / 10;
            if (c == y)
            {
                return 1;   
            } 
            else
            {
                return 2;   
            }
        }
        else
        {
            return 2;
        }
    }
    else
    {
        return 3; 
    }    
}
Console.WriteLine("Введите число?");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
    int q = Funk(x);
    if (q == 1) Console.WriteLine("Да");
    if (q == 2) Console.WriteLine("Нет");
    if (q == 3) Console.WriteLine("Вы не ввели пятизначное число!");
}
else
{
    int q = Funk(-x);
    if (q == 1) Console.WriteLine("Да");
    if (q == 2) Console.WriteLine("Нет");
    if (q == 3) Console.WriteLine("Вы не ввели пятизначное число!");
}
Console.Write("Выход.");
Console.ReadLine();
