﻿


Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc)

{
    if (xc == 1) return "x > 0, y > 0";
    if (xc == 1) return "x < 0, y > 0";
    if (xc == 1) return "x < 0, y < 0";
    if (xc == 1) return "x > 0, y < 0";
    return "Введите число от 1 до 4";
}
    
    string result = Quarter(x);
    Console.WriteLine(result);