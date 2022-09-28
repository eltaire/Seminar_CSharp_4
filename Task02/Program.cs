// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int GetNmb()
// {
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
// }

int SolveTask(int a)
{
    int b = 0;
    while(Math.Abs(a/10) > 0)
    {
        a = a/10;
        b++; 
    }
    return b;
}
Console.WriteLine("    " + SolveTask(a));