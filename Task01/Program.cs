// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int GetA()
{
    int num= 0;
    while (num <= 1)
    {
        Console.WriteLine("Введите число");
        num = Convert.ToInt32(Console.ReadLine());
        }
    return num;
}
int GetSum(int A)
{
    int summ = 0;
   for (int i = 1; i <= A; i++)
    {
        summ += i;
    }
    return summ;
}
int A = GetA();
Console.WriteLine("Сумма чисел от 1 до " + A + " равна " + GetSum(A));