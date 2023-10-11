//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int Second(String msg)
{
    Console.WriteLine(msg);
    string str=Console.ReadLine();       
    int namber;
    namber=int.Parse(str);
    return namber;
}
int number=Second("Введите трехзначное число");
if (number>=100&&number<1000)
{
    int mid = (number%100-number%10)/10;
    Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
Console.WriteLine("Это число не трехзначное");