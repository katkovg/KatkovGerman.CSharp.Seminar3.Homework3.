// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void definePalindrome (int number)
{
    int secondHalfOfNumber = number % 100;
    int firstHalfOfNumber = number / 1000;

    int decSecondHalfOfNumber = secondHalfOfNumber / 10;
    int edSecondHalfOfNumber = secondHalfOfNumber % 10;

    int decFirstHalfOfNumber = firstHalfOfNumber / 10;
    int edFirstHalfOfNumber = firstHalfOfNumber % 10;

    if (edSecondHalfOfNumber == decFirstHalfOfNumber && edFirstHalfOfNumber == decSecondHalfOfNumber)
    {
        Console.WriteLine("Yes, it is a palindrome.");
    }
    else
    {
        Console.WriteLine("No, it is not a palindrome.");
    }
}


Console.WriteLine("Input a five-digit number:");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber < 100000 && userNumber > 9999)
{
    definePalindrome(userNumber);
}
else 
{
    Console.WriteLine("It is a wrong number! Input a five-digit number.");
}
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double determineDistance(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double cathetX = aX - bX;
    double cathetY = aY - bY;
    double distance1 = Math.Sqrt(Math.Pow(cathetX, 2) + Math.Pow(cathetY, 2));
    double cathet3 = aZ - bZ;
    double distance2 = Math.Sqrt(Math.Pow(distance1, 2) + Math.Pow(cathet3, 2));
    return distance2;
}


Console.WriteLine("Input X-coordinate for first point:");
double aX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y-coordinate for first point:");
double aY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z-coordinate for first point:");
double aZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input X-coordinate for second point:");
double bX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y-coordinate for second point:");
double bY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z-coordinate for second point:");
double bZ = Convert.ToDouble(Console.ReadLine());

double distance = determineDistance(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine($"The distance between these two points in 3D-space is {distance}.");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Method(int userNumber)
{
    int currentNumber = 1;
    double result = 1;
    if (userNumber > 1)
    {
         while (currentNumber <= userNumber)
        {
            result = Math.Pow(currentNumber, 3);
            Console.WriteLine(result);
            currentNumber++;
        }
    }
    else
    {
        Console.WriteLine("Input a number greater than one.");
    }
}

Console.WriteLine("Input an amount of numbers:");
int amountNumbers = Convert.ToInt32(Console.ReadLine());

Method(amountNumbers);
*/
