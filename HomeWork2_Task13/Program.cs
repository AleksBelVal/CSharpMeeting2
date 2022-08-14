// Программа выводит третью цифру заданного числа
// или сообщает что третьей цифры нет.

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 100;
int num2 = num1 % 10;

if (num2 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра: {num2}");
} 