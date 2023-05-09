// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
string num1 = Convert.ToString(Console.ReadLine());
char[] temp = num1.ToCharArray();
Array.Reverse(temp);                                    //разворот массива символов
string num2 = new string(temp);                         //изменение типа данных с массива на строку для сравнения

if (num1 == num2)                                       //проверка на полиндром
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}