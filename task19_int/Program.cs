// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine()); //число
double num2 = 0;    //перевернутое число
int n = 0;          //кол-во цифр в цисле
int digit = 0;      //цифра в числе
int temp = num1;    //переменная

for (int count = num1; count > 0; count /= 10)   //определение кол-ва цифр в цисле
{
    n++;
}

while (n > 0)       //переворот числа
{
    digit = temp % 10;
    temp = temp / 10;
    n = n-1;
    num2 = digit * Math.Pow(10 , n) + num2;
}

if (num1==num2)     //проверка на полиндром
{
    System.Console.Write("да");
}
else
{
    System.Console.WriteLine("нет");
}