// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    if (num !=0)
    {
        if (num < 0) num = -num;
        int count = default;
        while (num > 0)
        {
            num = num /10;
            count++;
        }
        return count;
    }
    return 1;
}

int result = CountDigits(number);
Console.WriteLine(result);


