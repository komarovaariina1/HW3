// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.Readline());

int SumNumbers(int num)
{
    int sum = default; 
    for (int i = 1; i < num; i++)
    {
        // sum = sum + i;
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
