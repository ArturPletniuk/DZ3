//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
double Lenge( int xa,int ya, int za,int xb,int yb, int zb)
{
    double r =  Math.Sqrt (Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2));
    double w = Math.Round(r,2,MidpointRounding.ToZero);
    return w;
}
Console.WriteLine("Введите число X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z2:");
int z2 = Convert.ToInt32(Console.ReadLine());
double T = Lenge(x1,y1,z1,x2,y2,z2);
Console.WriteLine();
Console.WriteLine(T);
Console.Write("Выход.");
Console.ReadLine();
