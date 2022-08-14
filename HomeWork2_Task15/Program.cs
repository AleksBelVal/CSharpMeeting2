// Программа принимает на вход цифру 
// обозначающую день недели
// проверяет является ли этот день выходным

Console.WriteLine("Введите число обозначающее день недели: ");
int DayNum = Convert.ToInt32(Console.ReadLine());

if (DayNum == 6 || DayNum == 7)
{
    Console.WriteLine("Этот день - выходной");
}
else
{
    Console.WriteLine("Этот день - не выходной");
} 