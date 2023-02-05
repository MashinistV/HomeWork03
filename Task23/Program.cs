//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите целое число: ");
int N;
while (!int.TryParse(Console.ReadLine(), out N))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("Введите целое число: ");
}
int index = 1;
Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
while (index <= N)
{
    int result = (int)Math.Pow(index, 3);
    Console.Write($"{result} ");
    index++;
}
Console.WriteLine();