void Zadacha25()
{
    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    int a = 5;
    int b = 3;
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *=a;
    }
    Console.WriteLine($"{a}^{b} = {result}");

}
Zadacha25();

