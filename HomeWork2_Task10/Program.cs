// Программа принимает трёхзначное число
// на выходе показывает вторую цифру.

Console.WriteLine("Введите трёхзначное, целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 10;
int num2 = num1 % 10;

Console.WriteLine($"Вторая цифра: {num2}");
