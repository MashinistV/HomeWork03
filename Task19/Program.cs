//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите целое пятизначное число: ");
int.TryParse(Console.ReadLine(), out int number);
while (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели неверную цифру");
    Console.Write("Введите целое пятизначное число: ");
    int.TryParse(Console.ReadLine(), out number);
}
if (((number % 100000) / 10000) == (number % 10) && ((number % 10000) / 1000) == ((number % 100) / 10))
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}