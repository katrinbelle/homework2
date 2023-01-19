/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
Console.Write("Введите цифру недели -> ");
int GetValue()
{
    int  value= Convert.ToInt32(Console.ReadLine());
    return value;
}
int number = GetValue ();
while (number >7) {
    Console.Write(number+" не является днем недели. Пожалуйста, введите цифру недели -> ");
number=GetValue ();
}
if (number==6 || number==7) Console.WriteLine("Цифра "+ number+ " является выходным днем!");
else Console.WriteLine("Цифра "+ number+ " не является выходным днем");