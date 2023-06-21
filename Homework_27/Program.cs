/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

void Print(string text)
{
    Console.WriteLine(text);
}

int sum = 0;
int findSum(int Num)
{
    while (Num > 0)
    {
        sum = sum + Num % 10;
        Num = Num/10;
    }
    return(sum);
}

Print("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int Result = findSum(num);
Print($"Сумма цифр числа равна {Result}");


