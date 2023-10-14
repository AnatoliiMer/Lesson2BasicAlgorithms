// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int ThirdNumber(string msg)
{
  Console.WriteLine(msg);
  string str = Console.ReadLine();
  int number;
  number = int.Parse(str);
  return number;
  }