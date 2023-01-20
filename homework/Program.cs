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
int OutText(int value)
{
    Console.Write("Число "+value +"  не является трехзначным. Пожалуйста, введите трехначное число: ");
     value= GetValue();
     return value;
     }
int DataChecking(int data){
    if (data >-999 || data <-100){
       data= data *-1;
    } 
    return data;
}
second=DataChecking(second);
while (second >999 || second < 100) {
  second=OutText(second);
  second=DataChecking(second);
     }
second= SecontNumber(second);
 Console.WriteLine("Вторая цифра от введенного числа-> "+" "+second);