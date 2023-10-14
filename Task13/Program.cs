// Задача 13:выводит третью цифру задан Напишите программу, которая ного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ThirdNumber(string msg)
{
  Console.WriteLine(msg);
  string str = Console.ReadLine();
  int number;
  number = int.Parse(str);
  return number;
  }
int number = ThirdNumber("Введите число");
int fnumber(int number)
{
  while (number > 999)
  {
    number = number/10;
  }
  return number % 10;
}
bool check(int number)
{
  if (number < 100)
    return false;
  else return true;
}
if (check(number) != true)
  Console.WriteLine("Третьей цифры нет");
else
  Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}");
