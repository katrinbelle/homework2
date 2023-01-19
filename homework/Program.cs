/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 ->-> 1*/
Console.Write("Введите трехзначное число: ");
int GetValue ()
{
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int SecontNumber(int number)
{
number = (number/10)%10;
return number;
}
int second= GetValue();
while (second >999 || second < 100) {
     Console.Write("Число "+second +"  не является трехзначным. Пожалуйста, введите трехначное число: ");
     second= GetValue();
}
second= SecontNumber(second);
 Console.WriteLine("Вторая цифра от введенного числа-> "+" "+second);