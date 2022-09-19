// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Count (int num)
{
    int i;
    for (i = 0; i <= num; i++)
    {
       num = num/10;
    }
    return i;
}

int result = Count(number);
Console.Write(result);
