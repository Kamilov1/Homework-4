void Zadacha25()
{
    //Задача 25: Напишите цикл, который принимает на вход 
    //два натуральных числа (A и B) и возводить число A в степень B.

    Console.WriteLine("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int result = A;

    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    Console.WriteLine($"{A}^{B} = {result}");
}

void Zadacha27()
{
    //Задача 27: Напишите программу, которая принимает на 
    //вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Введите число C: ");
    int C = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;

    while (C > 0)
    {
        Sum += C % 10;
        C /= 10;
    }
    Console.WriteLine(Sum);
}

void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 
    //случайных целых чисел и выводит отсортированный по модулю массив.

    int size = 8;
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(-10, 11);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();

    for (int i = size - 1; i > 0; i--)
    {
        for (int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k + 1]))
            {
                int temp = array[k];
                array[k] = array[k + 1];
                array[k + 1] = temp;
            }
        }
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

//Zadacha25();
//Zadacha27();
Zadacha29();