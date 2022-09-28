// Программа, которая получает на вход число и выдает сумму цифр в числе
int GetNmb()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
int GetDigSum(int A)
{
    int B = 0;
    int sum = 0;
while(A >0)
{
    B = A % 10;
    sum =  sum + B;
    A = A / 10;
}
return sum;
}
int A = GetNmb();
int C = GetDigSum(A);
Console.WriteLine("Сумма цифр в Вашем числе равна " + C );