// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int GetNmb()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
int GetMult(int A)
{ 
    int mult = 1;
    for (int i = 1; i <= A; i++)
    {
        mult = mult * i;
    }
return mult;
}
int A = GetNmb();
Console.WriteLine("Произведение чисел от 1 до " + A + " равна " + GetMult(A));
