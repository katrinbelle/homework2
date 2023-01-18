/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 ->-> 1*/

int GetValue ()
{
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SecontNumber(int number)
{
number = (number/10)%10;
return number;
}
int value= SecontNumber(GetValue());
 Console.WriteLine("Вторая цифра от введенного числа-> "+" "+value);