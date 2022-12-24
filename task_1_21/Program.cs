// Задача 21 Напишите программу, 
// которая принимает на вход координаты двух точек 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int DataInput (string text)
{
Console.Write (text);
int x = Convert.ToInt32(Console.ReadLine());
return x;
}
int xa = DataInput("Введите координату x точки A: ");
int ya = DataInput("Введите координату у точки A: ");
int za = DataInput("Введите координату z точки A: ");

int xb = DataInput("Введите координату x точки B: ");
int yb = DataInput("Введите координату у точки B: ");
int zb = DataInput("Введите координату z точки B: ");

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
return (Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));
}

double res =Distance (xa, ya, za, xb, yb, zb);
res = Math.Round(res,2, MidpointRounding.ToZero);
Console.WriteLine ("Расстояние между точками: ");
Console.WriteLine ($"А({xa},{ya},{za}) и B({xb},{yb},{zb}) -> {res}");

