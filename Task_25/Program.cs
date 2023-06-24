// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt (string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Pow (int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i++)
    {
        res= res * A;
    }
    return res;
}

int numberA = ReadInt ("Введите число A: ");
int numberB = ReadInt ("Введите число B: ");
int res = Pow (numberA, numberB);
System.Console.WriteLine($"Число {numberA} в степени {numberB} равняется {res}");