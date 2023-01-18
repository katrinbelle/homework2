/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write("Введите любое число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int TrirdNumber (int number)
 {
     while ( number> 999)
     { number= number/10;}
    number =number%10;
    return number;
 }
if (number> 99) 
{
   number= TrirdNumber(number); 
   Console.WriteLine("Третья цифра от введенного числа  -> " +number);
}
else Console.WriteLine("Третьей цифры нет");