// //Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет,
// //является ли оно палиндромом.
// //14212 -> нет  12821 -> да  23432 -> да

// void Pal(int x)
// {
//     if ((x/10000) == (x % 10) && ((x % 10000) / 1000) == ((x % 100) / 10))
//         { Console.WriteLine("Это палиндром"); }
//     else    Console.WriteLine("Число не является палиндромом"); 
// }

// Console.WriteLine("Введите пятизначное число ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a < 10000 || a > 99999) Console.WriteLine("Число не является пятизначным ");

// else Pal(a);



// //Задача 21
// //Напишите программу, которая принимает на вход координаты двух точек 
// //и находит расстояние между ними в 3D пространстве.
// //A (3,6,8); B (2,1,-7), -> 15.84
// //A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z1 ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2 ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// void Dist(int a1, int a2, int b1, int b2, int c1, int c2)
// {
//     double dist =  Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) +
//      Math.Pow(c2 - c1, 2));
//     Console.WriteLine("Расстояние между точками = " + Math.Round(dist, 2));
// }

// Dist(x1, x2, y1, y2, z1, z2);


//Задача 23
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27;      5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

void Cube(int a)
{
    int i = 1;
    for (i = 1; i <= a; i++)    
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Cube(x);
Console.WriteLine(); //это для красоты.