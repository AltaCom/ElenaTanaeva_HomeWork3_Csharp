/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да


bool Poli(int Number)
{
while (Number <= 9999 || Number >= 99999)
{
    Console.Write("It's not a five-digit number!");
    Number = Convert.ToInt32(Console.ReadLine());
}
int digit1 = Number % 10;
int digit10 = (Number % 100) / 10;
int digit100 = (Number % 1000) / 100;
int digit1000 = (Number % 10000) / 1000;
int digit10000 = Number / 10000;

if (digit1 == digit10000 && digit10 == digit1000)
{
    Console.Write("The number" + Number + " is a Polindrom");
    return true;
}
else
{
    Console.Write("The number" + Number + " is not a Polindrom");
    return false;
}
}

Console.Write("Input number ");
int username = Convert.ToInt32(Console.ReadLine());
bool answer = Poli(username);
*/


/*

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53




double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
double dist = ((x2 - x1) * (x2 - x1)) + ((y2 -  y1) * (y2 - y1)) + ((z2 - z1)*(z2 - z1));
double result = Math.Sqrt(dist);

return result;

}

Console.Write("Input x1 = ");
double X1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1 = ");
double Y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1 = ");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2 = ");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2 = ");
double Y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z2 = ");
double Z2 = Convert.ToDouble(Console.ReadLine());

double Result = Distance(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine("Distance between points is " + Result);

*/


/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125



void Cube(int N)
{
    int current = 1;

while (current <= N)
{
int cube = current * current * current;
current++;
Console.Write(cube + " ");

}
}

Console.Write("Input number ");
int Result = Convert.ToInt32(Console.ReadLine());
Cube(Result);
*/



