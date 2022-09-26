void Zadacha27()
{
  // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = 17343;
int sum = 0;
Console.Write("Сумма цифр в числе " + number);
while(number > 0)
{
  sum += number%10;
  number /= 10;
}
Console.WriteLine(" равна " + sum);
}
Zadacha27();
  