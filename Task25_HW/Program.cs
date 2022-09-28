// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
    Console.WriteLine("Введите числоc A ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int B = Convert.ToInt32(Console.ReadLine());
    
    if(B > 0)
    {
        Console.WriteLine("Число А в степени В равно " + (Math.Pow(A, B)));
    }
    else 
    Console.WriteLine("Число B должно быть натуральным, исправьте, пожалуйста");
