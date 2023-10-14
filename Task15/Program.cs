// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int DayWeek(string msg)
{
    Console.WriteLine(msg);
    string str = Console.ReadLine();
    int number;
    number = int.Parse(str);
    return number;
}
int number = DayWeek("Введите число");
string not = "Это не день недели";
string check(int number)
{
    if (number >= 6 && number < 8) not = "Да, это выходной";
    if (number >= 1 && number < 7) not = "Нет, это будний день";
    return not;
}
Console.WriteLine(check(number));