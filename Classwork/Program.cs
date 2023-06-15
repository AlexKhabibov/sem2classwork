// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

/*
int Line()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine("Your num is " + num);
    int dec = num / 10;
    int ed = num % 10;
    if (dec > ed)
    {
        return dec;
    }
    else
    {
        return ed;
    }
}

Console.WriteLine("result is  " + Line());
*/

// Напишите прогрумму, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

/*
int num = new Random().Next(100, 1000);

    Console.WriteLine($"your number is {num}");
    int a = num / 100;
    int b = num % 10;

Console.WriteLine($"if del second figure, your number is {a}{b}");
*/

// Второе число является кратным первому

/*
Console.WriteLine("Input first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber % firstNumber == 0)
{
    Console.WriteLine("Второе число является кратным первому");
}
else
{
Console.WriteLine(secondNumber % firstNumber);
}
*/

// Программа, которая принимает на вход число и проверяет является  ли оно кратным 7 и 23 одновременно.

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine("Число кратное одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратное одновременно 7 и 23");
}
*/

// а теперь тоже самое через метод

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void numberDiv(int num)
{
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine("Число кратное одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратное одновременно 7 и 23");
}
}
getNumberDiv(numb)
*/

// Напишите программу, которая принимает на вход два числа и проверяет является ли первое число квадратом другого.

/*
Console.WriteLine(«Введите одно число»);
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(«Введите другое число»);
int number2 = Convert.ToInt32(Console.ReadLine());
{
if ((number2 == number1 * number1) || (number1 == number2 * number2))
Console.WriteLine(«Одно число является квадратом другого»);
}
else
{
Console.WriteLine(«Одно число не является квадратом другого»);
}
*/

// или второй вариант решения

/*
Void enterCount(int number1, int number2)
{
if ((number2 == number1 * number1) || (number1 == number2 * number2))
Console.WriteLine(«Одно число является квадратом другого»);
}
else
{
Console.WriteLine(«Одно число не является квадратом другого»);
}
enterCount(number1, number2)
*/
