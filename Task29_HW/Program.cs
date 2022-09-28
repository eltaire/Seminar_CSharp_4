// Напишите программу, которая задает массив из 8 элементов и выводит его на экран
void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
}
void PrintArray(int[] arr)
{
for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int[] massiv = new int[8];
FillArray(massiv);
PrintArray(massiv);