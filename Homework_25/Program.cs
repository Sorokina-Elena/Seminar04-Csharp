/*
Задача 25 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void Print(string text)
{
    Console.WriteLine(text);

}


double raiseToDegree(int Num1, int Num2)
{   
    double result = Math.Pow(Num1, Num2);
    return(result);
}

Print("Введите два числа");

int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());
double Res = raiseToDegree(Num1, Num2);
Console.WriteLine(Res);

