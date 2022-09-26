 void Zadacha29()
{
  // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 8;
int[] array = new int[size];

Random random = new Random();
for (int i = 0; i < size; i++)
{
  array[i] = random.Next(-10, 11);
}

for (int i = 0; i < size; i++)
{
  Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = size - 1; i > 0; i--)
{
  for(int k = 0; k < i; k++)
  {
    if(Math.Abs(array[k]) > Math.Abs(array[k+1]))
    {
      int temp = array[k];
      array[k] = array[k+1];
      array[k+1] = temp;
    }
  }
}

for (int i = 0; i < size; i++)
{
  Console.Write(array[i] + " ");
}
Console.WriteLine();
}

Zadacha29();