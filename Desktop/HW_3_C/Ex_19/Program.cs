/**Задача 19. Напишите программу, 
которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
**/

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int dig, sum;
sum = 0;

int numnum = num;

while (num > 0)
{
    dig = num % 10;
    sum = sum * 10 + dig;
    num = num / 10;
}

if (numnum == num)
{
    Console.Write("Введенное число [{num}] является палиндромом");
}
else
{
 Console.Write("Введенное число не является палиндромом");   
}
